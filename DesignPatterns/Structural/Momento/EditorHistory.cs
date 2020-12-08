using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Structural.Momento
{
   public class EditorHistory
   {
       private List<EditorState> editorStates=new List<EditorState>();

       public void Push(EditorState state)
       {
            editorStates.Add(state);
       }

       public EditorState Pop()
       {
           var lastIndex = editorStates.Count - 1;
           var lastState = editorStates[lastIndex];
           editorStates.RemoveAt(lastIndex);
           return lastState;
       }
   }
}
