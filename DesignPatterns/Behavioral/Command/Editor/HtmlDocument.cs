using System;

namespace PracticeProject.DesignPatterns.Behavioral.Command.Editor
{
  public  class HtmlDocument
  {
      public string Content { get; set; }

      public void MakeBold()
      {
          Content = "<b>" + Content + "</b>";
      }


  }
}
