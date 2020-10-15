using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.CreationalPatterns.Builder
{
  public  class Car
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public int NumDoors { get; set; }
        public string Color { get; set; }

        public Car(string model,string make,int numDoors,string color)
        {
            this.Color = color;
            this.Make = make;
            this.Model = model;
            this.NumDoors = numDoors;
        }
    }
}
