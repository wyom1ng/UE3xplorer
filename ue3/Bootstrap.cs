using System.Diagnostics;

namespace ue3;

public class ULinker(byte[] data) : FArchive(data)
{
    public string[]? Names;
    public Dictionary<string, int> NameMap = new(StringComparer.OrdinalIgnoreCase);
    public FObjectImport[]? Imports;
    public FObjectExport[]? Exports;

    public Dictionary<string, UClass> classes = new();
    public Dictionary<string, UEnum> enums = new();
    public Dictionary<string, Dictionary<string, UStruct>> structuresByOuter = new();

    public override void Serialise(ref FName name)
    {
        Serialise(ref name.PackageIndex);
        Serialise(ref name.Number);

        name.ResolveFrom(Names);
    }

    public UObject SerialiseObjectImport(FObjectImport import)
    {
        throw new NotImplementedException();
    }

    public UObject SerialiseObjectExport(FObjectExport export, int linkerIndex)
    {
        if (export.ResolvedObject != null) return export.ResolvedObject;

        if (export.ClassIndex == 0)
        {
            if (export.ObjectName == EName.None) return null;
            if (classes.ContainsKey(export.ObjectName.Resolved)) throw new PackageCorruptException("duplicate class");

            Seek(export.SerialOffset);
            UClass theClass = new(export, linkerIndex);
            theClass.Serialise(this);
            classes[export.ObjectName.Resolved] = theClass;

            return theClass;
        }

        FName className;
        if (export.ClassIndex < 0)
            className = Imports[-export.ClassIndex - 1].ObjectName;
        else
            className = Exports[export.ClassIndex - 1].ObjectName;

        if (className == EName.Enum)
        {
            if (enums.ContainsKey(export.ObjectName.Resolved))
                // sopme enums are duplicated, but always identical
                return export.ResolvedObject = enums[export.ObjectName.Resolved];

            Seek(export.SerialOffset);
            UEnum enumeration = new(export, linkerIndex);
            enumeration.Serialise(this);

            enums[export.ObjectName.Resolved] = enumeration;
            return enumeration;
        }

        if (className == EName.Function)
            return null;

        if (className == EName.Struct || className == "ScriptStruct")
        {
            FName outerName;
            if (export.OuterIndex < 0) outerName = Imports[-export.OuterIndex - 1].ObjectName;
            else outerName = Exports[export.OuterIndex - 1].ObjectName;

            if (!structuresByOuter.ContainsKey(outerName.Resolved))
                structuresByOuter[outerName.Resolved] = new();

            Dictionary<string, UStruct> byOuter = structuresByOuter[outerName.Resolved];
            if (byOuter.ContainsKey(export.ObjectName.Resolved))
                throw new PackageCorruptException("duplicate struct definition");

            Seek(export.SerialOffset);
            UStruct structure = new(export, linkerIndex);
            structure.Serialise(this);

            byOuter[export.ObjectName.Resolved] = structure;

            return structure;
        }

        return null;
    }

    public UProperty SerialiseProperty(FObjectExport export, int linkerIndex)
    {
        FName fieldClassName = GetObjectName(export.ClassIndex);
        UProperty property;

        if (fieldClassName == EName.ArrayProperty) property = new UArrayProperty(export, linkerIndex);
        else if (fieldClassName == EName.BoolProperty) property = new UBoolProperty(export, linkerIndex);
        else if (fieldClassName == EName.ByteProperty) property = new UByteProperty(export, linkerIndex);
        else if (fieldClassName == EName.DelegateProperty) property = new UDelegateProperty(export, linkerIndex);
        else if (fieldClassName == EName.FloatProperty) property = new UFloatProperty(export, linkerIndex);
        else if (fieldClassName == EName.InterfaceProperty) property = new UInterfaceProperty(export, linkerIndex);
        else if (fieldClassName == EName.IntProperty) property = new UIntProperty(export, linkerIndex);
        else if (fieldClassName == EName.MapProperty) property = new UMapProperty(export, linkerIndex);
        else if (fieldClassName == EName.NameProperty) property = new UNameProperty(export, linkerIndex);
        else if (fieldClassName == EName.StrProperty) property = new UStrProperty(export, linkerIndex);
        else if (fieldClassName == EName.StructProperty) property = new UStructProperty(export, linkerIndex);
        else if (fieldClassName == EName.ObjectProperty) property = new UObjectProperty(export, linkerIndex);
        else if (fieldClassName == EName.ClassProperty) property = new UObjectProperty(export, linkerIndex);
        else if (fieldClassName == "ComponentProperty") property = new UObjectProperty(export, linkerIndex);
        else throw new PackageCorruptException("unknown property type");

        Seek(export.SerialOffset);
        property.Serialise(this);
        return property;
    }

    public UObject? SerialiseObjectByIndex(int index)
    {
        if (index == 0) return null;
        if (index < 0)
            return SerialiseObjectImport(Imports[-index - 1]);

        return SerialiseObjectExport(Exports[index - 1], index - 1);
    }

    public FName GetObjectName(int index)
    {
        if (index == 0) return new(EName.None);
        if (index < 0) return Imports[-index - 1].ObjectName;
        return Exports[index - 1].ObjectName;
    }
}

public class UObject(FObjectExport export, int linkerIndex)
{
    public EObjectFlags ObjectFlags = export.ObjectFlags;
    public int NetIndex;
    public int LinkerIndex = linkerIndex;
    public UObject Outer;
    public FName Name = export.ObjectName;
    public int ClassIndex = export.ClassIndex;
    public UClass Class;

    public virtual void Serialise(ULinker linker)
    {
        linker.Serialise(ref NetIndex);

        if (ClassIndex != 0)
            SkipTaggedProperties(linker);
    }

    private void SkipTaggedProperties(ULinker linker)
    {
        while (true)
        {
            FName propertyName = new();
            linker.Serialise(ref propertyName);
            if (propertyName == EName.None) return;

            FName propertyType = new();
            linker.Serialise(ref propertyType);
            int size = 0;
            linker.Serialise(ref size);
            int arrayIndex = 0;
            linker.Serialise(ref arrayIndex);

            if (propertyType == EName.StructProperty)
            {
                FName structName = new();
                linker.Serialise(ref structName);
            }
            else if (propertyType == EName.BoolProperty)
            {
                byte boolValue = 0;
                linker.Serialise(ref boolValue);
            }
            else if (propertyType == EName.ByteProperty)
            {
                FName enumName = new();
                linker.Serialise(ref enumName);
            }

            linker.Skip(size);
        }
    }
}

public class UField(FObjectExport export, int linkerIndex) : UObject(export, linkerIndex)
{
    public int SuperFieldIndex;
    public int NextIndex;

    public override void Serialise(ULinker linker)
    {
        base.Serialise(linker);

        linker.Serialise(ref SuperFieldIndex);
        linker.Serialise(ref NextIndex);
    }
}

public class UProperty(FObjectExport export, int linkerIndex) : UField(export, linkerIndex)
{
    public int ArrayDim;
    public EPropertyFlags PropertyFlags;
    public FName Category;
    public int ArraySizeEnumIndex;
    public ushort RepOffset;

    public override void Serialise(ULinker linker)
    {
        base.Serialise(linker);

        linker.Serialise(ref ArrayDim);

        ulong propertyFlagsRaw = (ulong)PropertyFlags;
        linker.Serialise(ref propertyFlagsRaw);
        PropertyFlags = (EPropertyFlags)propertyFlagsRaw;

        linker.Serialise(ref Category);
        linker.Serialise(ref ArraySizeEnumIndex);

        if ((PropertyFlags & EPropertyFlags.CPF_Net) != 0)
            linker.Serialise(ref RepOffset);
    }
}

public class UArrayProperty(FObjectExport export, int linkerIndex) : UProperty(export, linkerIndex)
{
    public UProperty Inner;

    public override void Serialise(ULinker linker)
    {
        base.Serialise(linker);

        int innerIndex = 0;
        linker.Serialise(ref innerIndex);
        Debug.Assert(innerIndex > 0, "imported inners not implemented");

        FObjectExport innerExport = linker.Exports[innerIndex - 1];
        Inner = linker.SerialiseProperty(innerExport, innerIndex - 1);
    }
}

public class UBoolProperty(FObjectExport export, int linkerIndex) : UProperty(export, linkerIndex)
{
}

public class UByteProperty(FObjectExport export, int linkerIndex) : UProperty(export, linkerIndex)
{
    public int InnerIndex;

    public override void Serialise(ULinker linker)
    {
        base.Serialise(linker);

        linker.Serialise(ref InnerIndex);
    }
}

public class UDelegateProperty(FObjectExport export, int linkerIndex) : UProperty(export, linkerIndex)
{
    public int FunctionIndex;
    public int SourceDelegateIndex;

    public override void Serialise(ULinker linker)
    {
        base.Serialise(linker);

        linker.Serialise(ref FunctionIndex);
        linker.Serialise(ref SourceDelegateIndex);
    }
}

public class UFloatProperty(FObjectExport export, int linkerIndex) : UProperty(export, linkerIndex)
{
}

public class UInterfaceProperty(FObjectExport export, int linkerIndex) : UProperty(export, linkerIndex)
{
    public int InterfaceIndex;

    public override void Serialise(ULinker linker)
    {
        base.Serialise(linker);

        linker.Serialise(ref InterfaceIndex);
    }
}

public class UIntProperty(FObjectExport export, int linkerIndex) : UProperty(export, linkerIndex)
{
}

public class UMapProperty(FObjectExport export, int linkerIndex) : UProperty(export, linkerIndex)
{
    public int KeyIndex;
    public int MappedIndex;

    public override void Serialise(ULinker linker)
    {
        base.Serialise(linker);

        linker.Serialise(ref KeyIndex);
        linker.Serialise(ref MappedIndex);

        // should recursively serialise the inner properties, but in practice this is never set
        if (KeyIndex != 0 || MappedIndex != 0) throw new NotImplementedException();
    }
}

public class UNameProperty(FObjectExport export, int linkerIndex) : UProperty(export, linkerIndex)
{
}

public class UStrProperty(FObjectExport export, int linkerIndex) : UProperty(export, linkerIndex)
{
}

public class UStructProperty(FObjectExport export, int linkerIndex) : UProperty(export, linkerIndex)
{
    public int StructIndex;

    public override void Serialise(ULinker linker)
    {
        base.Serialise(linker);

        linker.Serialise(ref StructIndex);
    }
}

public class UObjectProperty(FObjectExport export, int linkerIndex) : UProperty(export, linkerIndex)
{
    public int PropertyClassIndex;

    public override void Serialise(ULinker linker)
    {
        base.Serialise(linker);

        linker.Serialise(ref PropertyClassIndex);
    }
}

public class UStruct(FObjectExport export, int linkerIndex) : UField(export, linkerIndex)
{
    public int ScriptTextIndex;
    public int ChildrenIndex;

    public int CppTextIndex;
    public int Line;
    public int TextPos;
    public int ScriptBytecodeSize;
    public int ScriptStorageSize;

    public List<FName> Properties = new();
    public Dictionary<string, UProperty> PropertyMap = new();

    public override void Serialise(ULinker linker)
    {
        base.Serialise(linker);

        linker.Serialise(ref ScriptTextIndex);
        linker.Serialise(ref ChildrenIndex);
        linker.Serialise(ref CppTextIndex);
        linker.Serialise(ref Line);
        linker.Serialise(ref TextPos);
        linker.Serialise(ref ScriptBytecodeSize);
        linker.Serialise(ref ScriptStorageSize);
        linker.Skip(ScriptStorageSize);

        int offset = linker.Tell();

        /* serialise children */
        {
            int currentFieldIndex = ChildrenIndex;
            while (currentFieldIndex != 0)
            {
                Debug.Assert(currentFieldIndex > 0, "imported children not handled");

                FObjectExport fieldExport = linker.Exports[currentFieldIndex - 1];
                linker.Seek(fieldExport.SerialOffset);

                UField field = new(fieldExport, currentFieldIndex - 1);
                field.Serialise(linker);

                FName fieldClassName = linker.GetObjectName(fieldExport.ClassIndex);
                if (fieldClassName.Resolved.EndsWith("Property"))
                {
                    FName propertyName = fieldExport.ObjectName;
                    Properties.Add(propertyName);

                    if (PropertyMap.ContainsKey(propertyName.Resolved)) throw new PackageCorruptException("duplicate property");
                    PropertyMap[propertyName.Resolved] = linker.SerialiseProperty(fieldExport, currentFieldIndex - 1);
                }

                currentFieldIndex = field.NextIndex;
            }
        }


        linker.Seek(offset);
    }
}

public class UState(FObjectExport export, int linkerIndex) : UStruct(export, linkerIndex)
{
}

public class UClass(FObjectExport export, int linkerIndex) : UState(export, linkerIndex)
{
}

public class UEnum(FObjectExport export, int linkerIndex) : UField(export, linkerIndex)
{
    public FName[] Names;

    public override void Serialise(ULinker linker)
    {
        base.Serialise(linker);

        linker.Serialise(ref Names);
    }
}

public class Bootstrap(string basePath)
{
    public string BasePath = basePath;
    public ULinker[] Linkers;

    public void GenerateDataStructures(string[] packageNames)
    {
        Linkers = new ULinker[packageNames.Length];

        int linkerIndex = 0;
        foreach (string packageName in packageNames)
        {
            byte[] data = File.ReadAllBytes(Path.Join(BasePath, packageName + ".upk"));
            ULinker linker = new ULinker(data);

            FPackageFileSummary summary = new();
            summary.Serialise(linker);


            linker.Seek(summary.NameOffset);
            linker.Names = new string[summary.NameCount];
            for (int i = 0; i < summary.NameCount; ++i)
            {
                ulong flags = 0;
                string name = "";

                linker.Serialise(ref name);
                linker.Serialise(ref flags);

                string nameSegment = SplitName(name, out _);

                linker.Names[i] = name;
                linker.NameMap[nameSegment] = i;
            }

            linker.Seek(summary.ImportOffset);
            linker.Imports = new FObjectImport[summary.ImportCount];
            for (int i = 0; i < summary.ImportCount; ++i)
            {
                linker.Serialise(ref linker.Imports[i]);
                linker.Imports[i].ClassName.ResolveFrom(linker.Names);
                linker.Imports[i].ClassPackage.ResolveFrom(linker.Names);
                linker.Imports[i].ObjectName.ResolveFrom(linker.Names);
            }

            linker.Seek(summary.ExportOffset);
            linker.Exports = new FObjectExport[summary.ExportCount];
            for (int i = 0; i < summary.ExportCount; ++i)
            {
                linker.Serialise(ref linker.Exports[i]);
                linker.Exports[i].ObjectName.ResolveFrom(linker.Names);
            }


            for (int i = 0; i < summary.ExportCount; ++i)
            {
                FObjectExport export = linker.Exports[i];
                linker.SerialiseObjectExport(export, i);
            }

            Linkers[linkerIndex++] = linker;
        }
    }

    private static string SplitName(string input, out string numberSegment)
    {
        int nameLength = input.Length;
        char lastChar = '\0';
        for (int i = nameLength - 1; i > 0; --i)
        {
            char currentChar = input[i];
            // check the last underscore to see if we need to split
            if (currentChar == '_')
            {
                // "somename_01" should not be split, so check the last numeric character
                bool isFirstNumericCharacter = i == nameLength - 2;
                if (lastChar != '0' || isFirstNumericCharacter) nameLength = i;
                break;
            }

            // not numeric, don't split "somename_12xyz3"
            if (currentChar < '0') break;
            if (currentChar > '9') break;
            lastChar = currentChar;
        }

        if (nameLength == input.Length)
        {
            numberSegment = "";
            return input;
        }

        string nameSegment = input[..nameLength];
        numberSegment = input[(nameLength + 1)..];
        return nameSegment;
    }
}