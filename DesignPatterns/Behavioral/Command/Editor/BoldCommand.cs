using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Behavioral.Command.Editor
{
  public  class BoldCommand : IUndoableCommand
  {
      private string prevContent;

      private HtmlDocument htmlDocument;
      private History history;

      public BoldCommand(HtmlDocument htmlDocument, History history)
      {
          this.htmlDocument = htmlDocument;
          this.history = history;
      }

      public void Execute()
      {
          prevContent = htmlDocument.Content;
          htmlDocument.MakeBold();
          history.Push(this);
      }

        public void UnExecute()
        {
            htmlDocument.Content = prevContent;
        }
    }
}
