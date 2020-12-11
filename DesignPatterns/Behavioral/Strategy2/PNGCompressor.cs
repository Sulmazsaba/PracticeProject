using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Behavioral.Strategy2
{
  public  class PngCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("applying png compressor");
        }
    }
}
