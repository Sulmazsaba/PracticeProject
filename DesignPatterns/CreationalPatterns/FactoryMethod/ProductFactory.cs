using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.CreationalPatterns.FactoryMethod
{
   public abstract class ProductFactory
   {
       protected abstract IProduct CreateProduct();

       public IProduct GetFactory()
       {
           return this.CreateProduct();
       }
   }
}
