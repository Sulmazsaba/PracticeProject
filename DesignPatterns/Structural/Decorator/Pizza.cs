using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Structural.Decorator
{
   public abstract class Pizza
   {
       public string _description="Pizza";

        public string GetDescription()
        {
            return _description;
        }

        public abstract int GetCost();
   }
}
