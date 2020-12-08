using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.CreationalPatterns.Builder2
{
   public class Director
   {
       private IBuilder builder;

       public IBuilder Builder
       {
           set
           {
               builder = value;
           }
       }

       public void buildMinimalFeature()
       {
           builder.BuildStepA();
       }

       public void buildMaximumFeature()
       {
            builder.BuildStepA();
            builder.BuildStepB();
            builder.BuildStepC();
       }
   }
}
