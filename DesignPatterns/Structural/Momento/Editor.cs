using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Structural.Momento
{
   public class Editor
   {
       public string Content { get;  set; }

       public EditorState CreateState()
       {
            return new EditorState(Content);
       }

       public void RestoreState(EditorState state)
       {
           Content = state.GetContent();
       }

       //public string GetContent()
       //{
       //    return Content;
       //}

       //public void SetContent()
       //{
            
       //}
       
   }
}
