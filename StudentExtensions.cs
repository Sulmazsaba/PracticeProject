using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject
{
   public static  class StudentExtensions
   {
        public delegate bool FindStudent(Student student);
        public static Student[] Where(this Student[] students,FindStudent delFindStudent)
        {
            var result =new Student[10];
            var i=0;
            foreach (var student in students)
            {
                if (delFindStudent(student))
                {
                    result[i] = student;
                    i++;
                }

            }
            return result;
        }
    }
}
