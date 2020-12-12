using System;
using PracticeProject.DesignPatterns.Behavioral.Iterator;
using PracticeProject.DesignPatterns.Behavioral.Strategy2;
using PracticeProject.DesignPatterns.Behavioral.TemplateMethod;

namespace PracticeProject.Executors
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

        public static void StrategyPattern2()
        {
            ImageStorage imageStorage=new ImageStorage();
            imageStorage.Store("my file1",new JpegCompressor(), new BlackAndWhiteFilter());
            imageStorage.Store("my file 1",new PngCompressor(), new BlackAndWhiteFilter());
        }

        public static void TemplateMethod()
        {
            var task = new TransferMoneyTask();
            task.Execute();
        }
    }
}
