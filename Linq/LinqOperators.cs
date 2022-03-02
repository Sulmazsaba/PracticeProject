using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticeProject.Linq
{
    public static class LinqOperators
    {

        static Student[] students;
        static Standard[] standards;

        static LinqOperators()
        {
            standards = StudentsService.GetStandards();
            students = StudentsService.GetStudents();
        }


        public static void GroupBy()
        {

            var studentGroups = students.GroupBy(i => i.Age);

            foreach (var studentGroup in studentGroups)
            {
                Console.WriteLine(studentGroup.Key);
                foreach (var student in studentGroup)
                {
                    Console.WriteLine(student.Name);
                }
            }
        }
        public static void JoinOperator()
        {
            // inner join in SQL

            var joinItems = students.Join(standards,
                i => i.StandardId
                , j => j.Id, (student, standard) =>
                    new
                    {
                        StudentName = student.Name,
                        StandardName = standard.Name
                    });

            foreach (var joinItem in joinItems)
            {
                Console.WriteLine(joinItem);
            }
        }

        public static void GroupJoin()
        {
            // left outer join in SQL
            var result = standards.GroupJoin(students,
                i => i.Id,
                j => j.StandardId,
                (standard, studentGroups) =>
               new
               {
                   Students = studentGroups,
                   standard
               }
            );


            foreach (var standardGroup in result)
            {
                Console.WriteLine($"standard :{standardGroup.standard.Name} , standardID : {standardGroup.standard.Id}");
                foreach (var student in standardGroup.Students)
                {
                    Console.WriteLine($"studentName : {student.Name}");
                }
            }
        }
    }
}
