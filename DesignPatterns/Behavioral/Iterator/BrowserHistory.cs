using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Behavioral.Iterator
{
   public class BrowserHistory
   {
      public List<string> urls=new List<string>();

      public string Pop()
      {
          var lastIndex = urls.Count - 1;
          var lastUrl = urls[lastIndex];
          return lastUrl;
      }

      public void Push(string url)
      {
            urls.Add(url);
      }

      public IIterator CreateIterator()
      {
            return new ListIterator(this);
      }


   }
}
