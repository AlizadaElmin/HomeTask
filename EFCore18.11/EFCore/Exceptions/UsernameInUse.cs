namespace EFCore.Exceptions;

public class UsernameInUse:Exception
{
    public UsernameInUse(string message) : base(message){}
}