using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Structural.Composite
{
   public abstract class Coffee
    {
        public int Calories { get; set; }
        public List<Coffee> Flavors { get; set; }

        public Coffee(int calories)
        {
            Calories = calories;
            Flavors=new List<Coffee>();
        }

        public void DisplayCalories()
        {
            Console.WriteLine(this.GetType().Name + ":" + this.Calories.ToString() + "");

            foreach (var drink in Flavors)
            {
                drink.DisplayCalories();
            }
        }
    }
}
