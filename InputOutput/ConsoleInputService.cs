﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class ConsoleInputService : InputOutput.IConsoleInputService
    {
        public string ReadCommand()
        {
            return (Console.ReadLine());
        }
        public Arguments ReadArguments()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            return(new Arguments(){
             X = x,
             Y = y
            });
        }
    }
}
