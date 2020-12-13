using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Behavioral.Command
{
  public  class Button
  {
      private ICommand command;

      public Button(ICommand command)
      {
          this.command = command;
      }

      public void Click()
        {
            command.Execute();
        }
    }
}
