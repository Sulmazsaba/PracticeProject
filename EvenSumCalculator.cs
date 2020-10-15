using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticeProject
{
  public class EvenSumCalculator : Calculator
    {
        public EvenSumCalculator(int[] numbers) : base(numbers)
        {
        }

        public override int CalculateSum() => _numbers.Where(i => i % 2 == 0).Sum();
    }
}
