using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Behavioral.TemplateMethod
{
  public abstract  class Task
  {
      private AuditTrail auditTrail;
      public Task(AuditTrail auditTrail)
      {
          this.auditTrail = auditTrail;
      }

      public Task()
      {
          auditTrail=new AuditTrail();
      }

      public void Execute()
      {
          auditTrail.Record();
          DoExecute();
      }
      protected abstract void DoExecute();
  }
}
