using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Structural.Decorator
{
  public abstract  class ToppingsDecorator :Pizza
  {
    public  abstract string GetDescription();
  }
}
