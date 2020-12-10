using System;
using System.Collections.Generic;
using System.Text;
using PracticeProject.DesignPatterns.Behavioral.Iterator;

namespace PracticeProject
{
   public static class ExecuteDesignPattern
    {
        public static void IteratorPattern()
        {  var history=new BrowserHistory();
            history.Push("first url");
            history.Push("second url");
            history.Push("third url");

            IIterator iterator = history.CreateIterator();

            while (iterator.HasNext())
            {
               var url= iterator.Current();
                Console.WriteLine(url);
                iterator.Next();
            }
        }
    }
}
