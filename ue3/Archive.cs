namespace ue3;

public interface ISerialisable
{
    public void Serialise(FArchive archive);
}

public class FArchive(byte[] data)
{
    private byte[] underlying = data;
    private int offset;

    public void Seek(int position)
    {
        if (position > underlying.Length) throw new OutOfBoundsException();
        offset = position;
    }

    public void Skip(int n)
    {
        if (offset + n > underlying.Length) throw new OutOfBoundsException();
        offset += n;
    }

    public int Tell()
    {
        return offset;
    }

    public virtual void Serialise(ref byte value)
    {
        if (offset + sizeof(byte) > underlying.Length) throw new OutOfBoundsException();

        value = underlying[offset];
        offset += sizeof(byte);
    }

    public virtual void Serialise(ref ushort value)
    {
        if (offset + sizeof(ushort) > underlying.Length) throw new OutOfBoundsException();

        value = BitConverter.ToUInt16(underlying, offset);
        offset += sizeof(ushort);
    }

    public virtual void Serialise(ref int value)
    {
        if (offset + sizeof(int) > underlying.Length) throw new OutOfBoundsException();

        value = BitConverter.ToInt32(underlying, offset);
        offset += sizeof(int);
    }

    public virtual void Serialise(ref uint value)
    {
        if (offset + sizeof(uint) > underlying.Length) throw new OutOfBoundsException();

        value = BitConverter.ToUInt32(underlying, offset);
        offset += sizeof(uint);
    }

    public virtual void Serialise(ref ulong value)
    {
        if (offset + sizeof(ulong) > underlying.Length) throw new OutOfBoundsException();

        value = BitConverter.ToUInt64(underlying, offset);
        offset += sizeof(ulong);
    }

    public virtual void Serialise(ref string value)
    {
        int indicatedLength = 0;
        Serialise(ref indicatedLength);
        if (indicatedLength == 0) throw new PackageCorruptException();

        if (indicatedLength < 0) // utf16
        {
            int nCharacters = -indicatedLength;
            int dataLength = nCharacters * 2;


            value = System.Text.Encoding.Unicode.GetString(underlying, offset, dataLength - 2);
            offset += dataLength;

            return;
        }

        value = System.Text.Encoding.ASCII.GetString(underlying, offset, indicatedLength - 1);
        offset += indicatedLength;
    }

    public virtual void Serialise<T>(ref T value) where T : ISerialisable
    {
        value.Serialise(this);
    }

    public virtual void Serialise(ref string[] values)
    {
        int length = 0;
        Serialise(ref length);

        values = new string[length];

        for (int i = 0; i < length; ++i)
            Serialise(ref values[i]);
    }

    public virtual void Serialise(ref int[] values)
    {
        int length = 0;
        Serialise(ref length);

        values = new int[length];

        for (int i = 0; i < length; ++i)
            Serialise(ref values[i]);
    }

    public virtual void Serialise<T>(ref T[] values) where T : ISerialisable
    {
        int length = 0;
        Serialise(ref length);

        values = new T[length];

        foreach (var value in values)
        {
            value.Serialise(this);
        }
    }

    public virtual void Serialise(ref FName[] values)
    {
        int length = 0;
        Serialise(ref length);

        values = new FName[length];

        for (int i = 0; i < length; ++i)
            Serialise(ref values[i]);
    }

    public virtual void Serialise(ref FName name)
    {
        Serialise(ref name.PackageIndex);
        Serialise(ref name.Number);
    }
}