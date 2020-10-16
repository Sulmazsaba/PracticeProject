using System.Collections.Generic;

namespace PracticeProject.DesignPatterns.Behavioral.Observer
{
  public  class BlogWriter :INotificationService
    {

        List<IBlogReader> _readers=new List<IBlogReader>();


        public void AddReader(IBlogReader reader)
        {
            _readers.Add(reader);
        }

        public void Notify(string message)
        {
            foreach (var blogReader in _readers)
            {
                blogReader.ReceiveNotification(message);
            }
        }
    }
}
