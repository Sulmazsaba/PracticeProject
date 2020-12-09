using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Behavioral.State2
{
   public class SelectionTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("selection icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("draw a dashed rectangle");
        }
    }
}
