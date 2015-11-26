using System;
namespace CalculatorCommandParsingLibrary
{
    public interface IInputParserService
    {
        Application.CommandTypes ParseCommand(string command);
    }
}
