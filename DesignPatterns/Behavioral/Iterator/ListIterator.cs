using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Behavioral.Iterator
{
   public class ListIterator : IIterator
   {
       private int index;
       private BrowserHistory history;

       public ListIterator(BrowserHistory history)
       {
           this.history = history;
       }

       public bool HasNext()
       {
           return history.urls.Count > index;
       }

        public string Current()
        {
            return history.urls[index];
        }

        public void Next()
        {
            index++;
        }
    }
}
