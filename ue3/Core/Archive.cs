using System.Text;

namespace ue3;

public enum ECompressionFlags {
  /** No compression																*/
  None = 0x00,
  /** Compress with ZLIB															*/
  ZLIB = 0x01,
  /** Compress with LZO															*/
  LZO = 0x02,
  /** Compress with LZX															*/
  LZX = 0x04,
};

public class OutOfBoundsException : Exception
{
}

public class PackageCorruptException : Exception
{
  public PackageCorruptException()
  {
  }

  public PackageCorruptException(string what) : base(what)
  {
  }
}

public interface ISerialisable
{
  public void Serialise(FArchive archive);
}

public class FArchive
{
  private int offset;
  private readonly byte[] underlying;

  public FArchive(string FilePath)
  {
    underlying = File.ReadAllBytes(FilePath);
  }

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


  public ulong Size()
  {
    return (ulong)underlying.Length;
  }

  public void Serialise(ref byte value)
  {
    if (offset + sizeof(byte) > underlying.Length) throw new OutOfBoundsException();

    value = underlying[offset];
    offset += sizeof(byte);
  }

  public void Serialise(ref sbyte value)
  {
    if (offset + sizeof(sbyte) > underlying.Length) throw new OutOfBoundsException();

    sbyte[] signed = (sbyte[])(Array)underlying;
    value = signed[offset];
    offset += sizeof(sbyte);
  }

  public void Serialise(ref ushort value)
  {
    if (offset + sizeof(ushort) > underlying.Length) throw new OutOfBoundsException();

    value = BitConverter.ToUInt16(underlying, offset);
    offset += sizeof(ushort);
  }

  public void Serialise(ref short value)
  {
    if (offset + sizeof(short) > underlying.Length) throw new OutOfBoundsException();

    value = BitConverter.ToInt16(underlying, offset);
    offset += sizeof(short);
  }


  public void Serialise(ref uint value)
  {
    if (offset + sizeof(uint) > underlying.Length) throw new OutOfBoundsException();

    value = BitConverter.ToUInt32(underlying, offset);
    offset += sizeof(uint);
  }

  public void Serialise(ref int value)
  {
    if (offset + sizeof(int) > underlying.Length) throw new OutOfBoundsException();

    value = BitConverter.ToInt32(underlying, offset);
    offset += sizeof(int);
  }

  public void Serialise(ref ulong value)
  {
    if (offset + sizeof(ulong) > underlying.Length) throw new OutOfBoundsException();

    value = BitConverter.ToUInt64(underlying, offset);
    offset += sizeof(ulong);
  }

  public void Serialise(ref long value)
  {
    if (offset + sizeof(long) > underlying.Length) throw new OutOfBoundsException();

    value = BitConverter.ToInt64(underlying, offset);
    offset += sizeof(long);
  }

  public void Serialise(ref string value)
  {
    int indicatedLength = 0;
    Serialise(ref indicatedLength);
    if (indicatedLength == 0) throw new PackageCorruptException();

    if (indicatedLength < 0) // utf16
    {
      int nCharacters = -indicatedLength;
      int dataLength = nCharacters * 2;


      value = Encoding.Unicode.GetString(underlying, offset, dataLength - 2);
      offset += dataLength;

      return;
    }

    value = Encoding.ASCII.GetString(underlying, offset, indicatedLength - 1);
    offset += indicatedLength;
  }

  public void Serialise<T>(ref T[] values) where T : ISerialisable
  {
    int length = 0;
    Serialise(ref length);

    values = new T[length];

    foreach (var value in values) value.Serialise(this);
  }

  public void Serialise<T>(ref List<T> values) where T : ISerialisable, new()
  {
    int length = 0;
    Serialise(ref length);

    values = new List<T>(length);
    for (int i = 0; i < length; ++i)
    {
      T value = new T();
      value.Serialise(this);
      values.Add(value);
    }
  }

  public void Serialise(ref List<string> values)
  {
    int length = 0;
    Serialise(ref length);

    values = new List<string>(length);
    for (int i = 0; i < length; ++i)
    {
      string value = "";
      Serialise(ref value);
      values.Add(value);
    }
  }
}