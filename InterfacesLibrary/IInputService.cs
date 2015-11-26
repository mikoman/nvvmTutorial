using System;
namespace InputOutput
{
    public interface IConsoleInputService
    {
        Application.Arguments ReadArguments();
        string ReadCommand();
    }
}
