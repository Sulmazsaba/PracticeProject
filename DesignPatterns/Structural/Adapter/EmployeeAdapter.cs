using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Structural.Adapter
{
    public class EmployeeAdapter : ThirdPartyEmployee,ITarget
    {
        public List<string> GetEmployees()
        {
            return GetEmployeeList();
        }
    }
}
