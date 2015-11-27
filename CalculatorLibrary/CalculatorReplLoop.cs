using CalculatorCommandParsingLibrary;
using CalculatorLibrary;
using InputOutput;

namespace Application
{
    public class CalculatorReplLoop : CalculatorLibrary.ICalculatorReplLoop
    {
        public CalculatorReplLoop(ICalculator calculator, IInputService inputService, IOutputService outputService, IInputParserService parsingService)
        {
            this.calculator = calculator;
            this.inputService = inputService;
            this.outputService = outputService;
            this.parsingService = parsingService;

        }
         ICalculator calculator;
         IInputService inputService;
         IOutputService outputService;
         IInputParserService parsingService;

            
        

        public void Run()
        {
            while (true)
            {
                string command = inputService.ReadCommand();

                try
                {
                    CommandTypes commandType = parsingService.ParseCommand(command);

                    Arguments args = inputService.ReadArguments();

                    outputService.WriteMessage(calculator.Execute(commandType, args).ToString());
                }
                catch
                {
                    outputService.WriteMessage("Mistake!");
                }
            }
        }
    
    }
}
