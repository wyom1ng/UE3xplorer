using System.Diagnostics;
using System.IO.Compression;
using System.Text;
using lzo.net;

namespace ue3;

public enum ECompressionFlags
{
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
  public void Serialise(FArchive Archive);
}

public class FArchive
{
  public EFileVersion Version;

  private int offset;
  private readonly byte[] underlying;
  private string[] names;
  private ULinker sourceLinker;

  public FArchive(string FilePath)
  {
    underlying = File.ReadAllBytes(FilePath);
  }

  public void SetNames(string[] InNames)
  {
    names = InNames;
  }

  public void SetSourceLinker(ULinker linker)
  {
    sourceLinker = linker;
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

  public void Serialise(ref float value)
  {
    if (offset + sizeof(float) > underlying.Length) throw new OutOfBoundsException();

    value = BitConverter.ToSingle(underlying, offset);
    offset += sizeof(float);
  }

  public void Serialise(ref double value)
  {
    if (offset + sizeof(double) > underlying.Length) throw new OutOfBoundsException();

    value = BitConverter.ToDouble(underlying, offset);
    offset += sizeof(double);
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

  public void Serialise(ref FName name)
  {
    Serialise(ref name.PackageIndex);
    Serialise(ref name.Number);

    if (names != null) name.ResolveFrom(names);
  }

  public void Serialise<T>(ref T value) where T : UObject
  {
    sourceLinker.SerialiseObjectRef<T>(ref value);
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

  public void Serialise(ref List<int> values)
  {
    int length = 0;
    Serialise(ref length);

    values = new List<int>(length);
    for (int i = 0; i < length; ++i)
    {
      int value = 0;
      Serialise(ref value);
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

  public void SerialiseRaw(ref byte[] To)
  {
    if (offset + To.Length > underlying.Length) throw new OutOfBoundsException();

    Array.Copy(underlying, offset, To, 0, To.Length);
    offset += To.Length;
  }

  private struct CompressedChunkHeader
  {
    public uint Tag;
    public int CompressionChunkSize;
  }

  private struct CompressedChunkInfo
  {
    public int CompressedSize;
    public int DecompressedSize;
  }

  public void SerialiseCompressedLZO(ref byte[] To)
  {
    CompressedChunkHeader Header = new();
    Serialise(ref Header.Tag);
    Serialise(ref Header.CompressionChunkSize);

    if (Header.Tag == ULinker.FPackageFileSummary.PACKAGE_FILE_TAG_BYTESWAPPED) throw new NotImplementedException();
    if (Header.Tag != ULinker.FPackageFileSummary.PACKAGE_FILE_TAG) throw new PackageCorruptException();


    CompressedChunkInfo Total = new();
    Serialise(ref Total.CompressedSize);
    Serialise(ref Total.DecompressedSize);

    int ChunkCount = (Total.DecompressedSize + Header.CompressionChunkSize - 1) / Header.CompressionChunkSize;
    CompressedChunkInfo[] Chunks = new CompressedChunkInfo[ChunkCount]; 

    for (int i = 0; i < ChunkCount; ++i)
    {
      Serialise(ref Chunks[i].CompressedSize);
      Serialise(ref Chunks[i].DecompressedSize);
    }

    if (offset + Total.CompressedSize > underlying.Length) throw new OutOfBoundsException();
    Debug.Assert(Total.DecompressedSize == To.Length);

    MemoryStream ToStream = new(To, true);
    for (int i = 0; i < ChunkCount; ++i)
    {
      LzoStream lzo = new LzoStream(new MemoryStream(underlying, offset, Chunks[i].CompressedSize), CompressionMode.Decompress);
      lzo.CopyTo(ToStream);
      
      offset += Chunks[i].CompressedSize;
    }
  }
}