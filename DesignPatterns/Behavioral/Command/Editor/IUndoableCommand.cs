using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Behavioral.Command.Editor
{
   public interface IUndoableCommand : ICommand
   {
       void UnExecute();
   }
}
