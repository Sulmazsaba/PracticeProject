using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Behavioral.Strategy
{
   public class MathAdd :IMathOperator
    {
        public int Operation(int a, int b)
        {
            return a + b;
        }
    }
}
