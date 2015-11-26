using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class CalculatorReplLoop
    {
        public CalculatorReplLoop()
        {
            calculator = new Calculator();
            inputParserService = new InputParserService();
            inputService = new ConsoleInputService();
            outputService = new ConsoleOutputService();
            
        }

        public void Run()
        {
            while (true)
            {
                string command = inputService.ReadCommand();

                try
                {
                    CommandTypes commandType = inputParserService.ParseCommand(command);

                    Arguments args = inputService.ReadArguments();

                    outputService.WriteMessage(calculator.Execute(commandType, args).ToString());
                }
                catch
                {
                    outputService.WriteMessage("Mistake!");
                }
            }
        }
        ConsoleInputService inputService;
        ConsoleOutputService outputService;
        Calculator calculator;
        InputParserService inputParserService;
    }
}
