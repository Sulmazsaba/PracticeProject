using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.Linq
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int StandardId { get; set; }

        public string GetFullName(string middleName , string lastName) => $"{Name} {middleName} {lastName}";

    }
}
