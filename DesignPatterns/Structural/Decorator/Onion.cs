using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Structural.Decorator
{
   public class Onion : ToppingsDecorator
   {
       private Pizza pizza;

       public Onion(Pizza pizza)
       {
           this.pizza = pizza;
       }

       public override string GetDescription()
       {
           return this.pizza.GetDescription() + ",onion";
       }

        public override int GetCost()
        {
            return this.pizza.GetCost() + 10;
        }
    }
}
