using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Behavioral.Iterator
{
   public interface IIterator
   {
       bool HasNext();
       string Current();
       void Next();

   }
}
