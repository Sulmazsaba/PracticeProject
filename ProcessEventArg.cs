using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject
{
   public class ProcessEventArg :EventArgs
    {
        public bool IsSuccessful { get; set; }
        public DateTime CompilationDateTime { get; set; }

    }
}
