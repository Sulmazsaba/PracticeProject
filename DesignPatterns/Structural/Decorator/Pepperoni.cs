using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Structural.Decorator
{
   public class Pepperoni : Pizza
    {
        public Pepperoni()
        {
            _description = "Pepperoni";
        }
        public override int GetCost()
        {
            return 10;
        }

        
    }
}
