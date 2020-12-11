using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Behavioral.Strategy2
{
   public class BlackAndWhiteFilter : IFilter
    {
        public void Filter(string fileName)
        {
            Console.WriteLine("applying black and white filter");
        }
    }
}
