using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Behavioral.Command.Editor
{
  public class History
    {
        private Queue<IUndoableCommand> commands=new Queue<IUndoableCommand>();

        public void Push(IUndoableCommand command)
        {
            commands.Enqueue(command);
        }

        public IUndoableCommand Pop()
        {
            var command = commands.Dequeue();
            return command;
        }

        public int Size()
        {
            return commands.Count;
        }
    }
}
