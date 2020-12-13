using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Behavioral.Command.Editor
{
  public  class UndoCommand : ICommand
  {
      private History history;

      public UndoCommand(History history)
      {
          this.history = history;
      }

      public void Execute()
        {
            if(history.Size()>0)
                history.Pop().Execute();
        }
    }
}
