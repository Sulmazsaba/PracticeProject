using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject
{
   public static class StudentsService
    {
        public static Student[] GetStudents()
        {
            
            Student[] studentArray=new Student[]
            {
                new Student()
                {
                    Id = 1,Name = "Bob",Age = 23 ,StandardId = 1
                },
                new Student()
                {
                    Id = 2,Name = "John",Age = 44,StandardId = 3
                },
                new Student()
                {
                    Id = 3,Name = "Pierson" ,Age = 80 , StandardId = 1
                },
                new Student()
                {
                    Id = 4,Name = "Saba" , Age = 34,StandardId = 3
                },
                new Student()
                {
                    Id=5 , Name = "Halsey" , Age = 12, StandardId = 3
                }, 
                new Student()
                {
                    Id = 6,Name = "Jack",Age = 34
                },
                new Student()
                {
                    Id = 7,Name = "Joe",Age = 34
                }, 
            };

            return studentArray;
        }

        public static Standard[] GetStandards()
        {
            return new Standard[]
            {
                new Standard()
                {
                    Id=1,
                    Name = "Standard 1",
                },
                new Standard()
                {
                    Id = 2,
                    Name = "Standard 2"
                }, 
                new Standard()
                {
                    Id = 3,
                    Name = "Standard 3"
                }, 
            };

        }
    }
}
