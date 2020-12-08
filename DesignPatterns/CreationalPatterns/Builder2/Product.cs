using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.CreationalPatterns.Builder2
{
   public class Product
    {
        private List<object> _parts =new List<object>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public string ListParts()
        {
            string result=String.Empty;

            foreach (string part in _parts)
            {
                result += part + " , ";
            }
            return result;
        }

    }
}
