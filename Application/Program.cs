using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;
using InputOutput;
using CalculatorCommandParsingLibrary;

using System.Configuration;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {     

            UnityContainer container = new UnityContainer();

            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            section.Configure(container, string.Empty);

        

            ICalculatorReplLoop loop = container.Resolve<ICalculatorReplLoop>();
          
            loop.Run();
        }
    }
}
