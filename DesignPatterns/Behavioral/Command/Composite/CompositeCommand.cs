using System;
using System.Collections.Generic;

namespace PracticeProject.DesignPatterns.Behavioral.Command.Composite
{
  public  class CompositeCommand :ICommand
    {
        
        List<ICommand> commands=new List<ICommand>();

        public void AddCommand(ICommand command)
        {
            commands.Add(command);
        }
        public void Execute()
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
        }
    }
}
