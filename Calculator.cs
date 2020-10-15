using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace PracticeProject
{
   public abstract class Calculator
   {
       protected readonly int[] _numbers;

       protected Calculator(int[] numbers)
       {
           _numbers = numbers;
       }

       public abstract int CalculateSum();
   }
}
