using PracticeProject.CalculatorEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticeProject
{
    public class SumCalculator : Calculator
    {
        public SumCalculator(int[] numbers) : base(numbers)
        {
        }

        public override int CalculateSum() => _numbers.Sum();
    }
}
