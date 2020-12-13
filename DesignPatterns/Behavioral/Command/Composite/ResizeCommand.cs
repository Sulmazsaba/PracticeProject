using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Behavioral.Command.Composite
{
   public class ResizeCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("resize");
        }
    }
}
