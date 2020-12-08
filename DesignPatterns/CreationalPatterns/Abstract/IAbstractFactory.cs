using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.CreationalPatterns.Abstract
{
  public  interface IAbstractFactory
  {
      IAbstractProductA CreateProductA();
      IAbstractProductB CreateProductB();
  }
}
