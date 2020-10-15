using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace PracticeProject.DesignPatterns.CreationalPatterns.Prototype
{
   public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public Address Address  { get; set; }
    }

   public class Address     
   {
       public string StreetName { get; set; }
   }
}
