using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.CreationalPatterns.FactoryMethod
{
  public  class TabletFactory :ProductFactory
    {
        protected override IProduct CreateProduct()
        {
            IProduct product=new Tablet();
            product.SetPrice(10000);
            return product;
        }
    }
}
