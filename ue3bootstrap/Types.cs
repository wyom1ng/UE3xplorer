namespace ue3bootstrap;

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
