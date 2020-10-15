using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject
{
    public delegate void Notify();
  public  class ProcessBuildLogic
  {
      public event Notify ProcessCompleted;
      public event EventHandler<ProcessEventArg> ProcessCompleted2;

      public void StartNotify()
      {
          Console.WriteLine("Process Started");
          OnProcessCompleted();
          OnProcessCompleted2(new ProcessEventArg()
          {
              CompilationDateTime = DateTime.Now,
              IsSuccessful = true
          });
      }
      protected virtual void OnProcessCompleted()
      {
          ProcessCompleted?.Invoke();
      }

      protected virtual void OnProcessCompleted2(ProcessEventArg a)
      {
          ProcessCompleted2?.Invoke(this, a);
      }
  }
}
