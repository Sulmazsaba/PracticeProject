using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Behavioral.TemplateMethod
{
   public class AuditTrail
    {
        public void Record()
        {
            Console.WriteLine("audit");
        }
    }
}
