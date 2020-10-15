using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.CreationalPatterns.Builder
{
   public class HondaBuilder :ICarBuilder
    {
        public string Color { get; set; }
        public int NumDoors { get; set; }

        public Car GetResult()
        {
            return new Car("1371","Germany",4,"Silver");
        }
    }
}
