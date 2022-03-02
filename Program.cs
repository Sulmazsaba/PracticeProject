using System;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using PracticeProject.CalculatorEvents;
using PracticeProject.DesignPatterns.CreationalPatterns.Abstract;
using PracticeProject.Executors;
using PracticeProject.Linq;

namespace PracticeProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //Executor.ExecuteBehavioralPatterns();
            //ExecuteDesignPattern.UndoableCommand();
            //ExecuteLinqOperators();

            //CallAbstractFactory(new ConcreteFactory1());
            //CallAbstractFactory(new ConcreteFactory2());

            dynamic o = new ExpandoObject();

            o.a = 10;
            o.b = "hello";

            var s = GetInsertString(o);
            Console.WriteLine(s);

            Console.ReadKey();

            //MemoryMarshal

        }

        private static string GetInsertString(dynamic o)
        {
            var expando = (ExpandoObject)o;

            return string.Format("INSERT INTO {0} ({1}) VALUES ({2});",
                "tableName",
                string.Join(",", expando.Select(x => x.Key)),
                string.Join(",", expando.Select(x => x.Value is string ? "'" + x.Value + "'" : x.Value.ToString())));
        }

    }
}
