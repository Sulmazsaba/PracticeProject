using System;

namespace PracticeProject.DesignPatterns.Behavioral.Observer
{
   public class BlogReader : IBlogReader
   {
       private string _name;

       public BlogReader(string name)
       {
           _name = name;
       }

       public void ReceiveNotification(string message)
        {
            Console.WriteLine(_name + " received notify with description :" + message);
        }
    }
}
