using PracticeProject.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Reflection
{
    public static class Test
    {
        public static void Execute()
        {
            Type t = typeof(Student);

            Console.WriteLine(t.Name);
            Console.WriteLine(t.AssemblyQualifiedName);

            var student = new Student();
            Console.WriteLine(student.GetType());

            int[] numbers = { 1, 2, 3 };

            Console.WriteLine(numbers.GetType().GetElementType());

            Student student1 = (Student)Activator.CreateInstance(t);
            student1.Age = numbers[0];
            Console.WriteLine(student1.Age);


            var members = t.GetMembers();
            foreach (var member in members)
            {
                if (member.MemberType == MemberTypes.Property)
                    Console.WriteLine(member.Name);
            }

            //var methods = typeof(Calculator).GetMethods();
            //foreach (var method in methods)
            //{
            //    Console.WriteLine(method.Name);
            //}

            foreach (Type type in typeof(System.Environment).GetNestedTypes())
            {

                Console.WriteLine(type.FullName);
            }

            //LateBinding();
        }


        public static void LateBinding()
        {
            var assembly = Assembly.GetExecutingAssembly();

            Type studentType = assembly.GetType("PracticeProject.Linq.Student");

            object student = Activator.CreateInstance(studentType);


            var method = studentType.GetMethod("GetFullName");

            var fullName = method.Invoke(student, new object[] { "Ebrahimi", "Saba" });
            Console.WriteLine(fullName);

        }
    }
}
