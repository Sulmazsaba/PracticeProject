using System;
using PracticeProject.DesignPatterns.Behavioral.Command;
using PracticeProject.DesignPatterns.Behavioral.Command.Composite;
using PracticeProject.DesignPatterns.Behavioral.Command.Editor;
using PracticeProject.DesignPatterns.Behavioral.Iterator;
using PracticeProject.DesignPatterns.Behavioral.Strategy2;
using PracticeProject.DesignPatterns.Behavioral.TemplateMethod;
using ICommand = PracticeProject.DesignPatterns.Behavioral.Command.ICommand;

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

        public static void Command()
        {
            var customerService=new CustomerService();
            ICommand command=new AddCustomerCommand(customerService);
            var button=new Button(command);
            button.Click();
        }

        public static void CompositeCommand()
        {
            var commands=new CompositeCommand();
            commands.AddCommand(new ResizeCommand());
            commands.AddCommand(new BlackAndWhiteCommand());

            var button=new Button(commands);
            button.Click();
        }

        public static void UndoableCommand()
        {
            var history=new History();
            var document=new HtmlDocument();
            document.Content = "Hello!";

            var boldCommand=new BoldCommand(document,history);
            boldCommand.Execute();
            Console.WriteLine(document.Content);

            var undoCommand=new UndoCommand(history);
            undoCommand.Execute();
            Console.WriteLine(document.Content);
        }
    }
}
