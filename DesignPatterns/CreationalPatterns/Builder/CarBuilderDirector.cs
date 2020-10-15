using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.CreationalPatterns.Builder
{
   public class CarBuilderDirector
   {
       private ICarBuilder CarBuilder;

       public CarBuilderDirector(ICarBuilder carBuilder)
       {
           CarBuilder = carBuilder;
       }

       public void Construct()
       {
           CarBuilder.GetResult();
       }
   }
}
