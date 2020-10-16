using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Structural.Adapter
{
  public  class ThirdPartyEmployee
    {
        public List<string> GetEmployeeList()
        {
            List<string> employees=new List<string>();
            employees.Add("ahmad javadi");
            employees.Add("sulmaz saba");

            return employees;
        }
    }
}
