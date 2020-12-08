using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Structural.Momento
{
   public class EditorState
   {
       private string content;

       public EditorState(string content)
       {
           this.content = content;
       }
   }
}
