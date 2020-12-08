using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.CreationalPatterns.Abstract
{
   public interface IAbstractProductB
   {
       string UsefulFunctionB();

       string AnotherUsefulFunctionB(IAbstractProductA collaborator);
   }
}
