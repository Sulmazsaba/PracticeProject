using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Behavioral.Command.Composite
{
   public class BlackAndWhiteCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("black and white");
        }
    }
}
