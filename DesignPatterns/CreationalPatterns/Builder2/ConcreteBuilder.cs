using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.CreationalPatterns.Builder2
{
  public  class ConcreteBuilder : IBuilder
    {
        private Product _product=new Product();

        public ConcreteBuilder()
        {
           Reset();
        }
        public void BuildStepA()
        {
            _product.Add("PartA1");
        }

        public void BuildStepB()
        {
            _product.Add("PartA2");
        }

        public void BuildStepC()
        {
           _product.Add("PartA3");
        }

        public void Reset()
        {
            this._product=new Product();
        }

        public Product GetProduct()
        {
            var result = _product;
            Reset();
            return result;
        }
    }
}
