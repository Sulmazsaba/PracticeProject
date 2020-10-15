using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.CreationalPatterns.Builder
{
   public interface ICarBuilder
   {
        string Color { get; set; }
        int NumDoors { get; set; }
       Car GetResult();
   }
}
