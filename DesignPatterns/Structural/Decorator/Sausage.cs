using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Structural.Decorator
{
   public class Sausage : Pizza
    {
        public Sausage()
        {
            _description = "Sausage";
        }
        public override int GetCost()
        {
            return 20;
        }
    }
}
