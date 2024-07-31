namespace ue3;

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

public struct FScriptDelegate
{
}

public struct FScriptInterface
{
}