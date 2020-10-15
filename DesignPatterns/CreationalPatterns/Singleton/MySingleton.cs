using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.CreationalPatterns.Singleton
{
  public  sealed class MySingleton
  {
      private static MySingleton _instance;
        private MySingleton()
        {
            
        }

        public static MySingleton Instance()
        {
            return _instance ?? new MySingleton();
        }
    }
}
