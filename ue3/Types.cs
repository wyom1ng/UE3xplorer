namespace ue3;

public class OutOfBoundsException : System.Exception
{
}

public class PackageCorruptException : System.Exception
{
    public PackageCorruptException()
    {
    }

    public PackageCorruptException(string what) : base(what)
    {
    }
}