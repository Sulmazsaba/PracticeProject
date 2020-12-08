using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.CreationalPatterns.Builder2
{
  public  interface IBuilder
  {
      void BuildStepA();

      void BuildStepB();

      void BuildStepC();
  }
}
