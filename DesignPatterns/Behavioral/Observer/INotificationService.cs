namespace PracticeProject.DesignPatterns.Behavioral.Observer
{
   public interface INotificationService
   {
       void AddReader(IBlogReader reader);
       void Notify(string message);


   }
}
