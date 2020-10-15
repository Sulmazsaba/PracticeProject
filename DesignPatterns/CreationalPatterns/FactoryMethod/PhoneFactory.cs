using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.CreationalPatterns.FactoryMethod
{
  public  class PhoneFactory : ProductFactory
    {
        protected override IProduct CreateProduct()
        {
            IProduct product=new Phone();
            product.SetPrice(200);
            return product;
        }
    }
}
