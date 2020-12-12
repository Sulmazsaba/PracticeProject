using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Behavioral.TemplateMethod
{
  public  class TransferMoneyTask : Task
    {
        protected override void DoExecute()
        {
            Console.WriteLine("transfer money task");

        }
    }
}
