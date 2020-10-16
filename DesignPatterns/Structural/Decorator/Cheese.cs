using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Structural.Decorator
{
   public class Cheese : ToppingsDecorator
   { 
       Pizza pizza;

       public Cheese(Pizza pizza)
       {
           this.pizza = pizza;
       }

       public override string GetDescription()
       {
           return this.pizza.GetDescription()  + ",Cheese";
       }

        public override int GetCost()
        {
            return this.pizza.GetCost() + 30;
        }
    }
}
