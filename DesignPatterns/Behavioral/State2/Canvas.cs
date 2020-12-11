using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Behavioral.State2
{
   public class Canvas
   {

       public ITool CurrentTool { get; set; }

       public void MouseDown()
       {
            CurrentTool.MouseDown();
       }  

       public void MouseUp()
       {
            CurrentTool.MouseUp();
       }

   }
}
