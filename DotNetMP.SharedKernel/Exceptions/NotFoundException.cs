namespace DotNetMP.SharedKernel.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException() : this("Not found.")
    { }

    public NotFoundException(string message) : base(message)
    { }

    public NotFoundException(string message, Exception innerException) : base(message, innerException)
    { }
}
