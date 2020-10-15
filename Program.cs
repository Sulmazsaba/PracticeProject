using System;
using PracticeProject.DesignPatterns.CreationalPatterns.Builder;
using PracticeProject.DesignPatterns.CreationalPatterns.FactoryMethod;

namespace PracticeProject
{ 
    public delegate void MyDelegate(string pm);
    class Program
    {
            static void Main(string[] args)
        {
            #region Indexers

            //IndexedNames names=new IndexedNames();
            //names[0] = "sulmaz";
            //names[1] = "ahmad";
            //names[2] = "javad";
            //names[7] = "navid";
            //names[3] = "jalal";

            //for (int i = 0; i < IndexedNames.ArraySize; i++)
            //{

            //    Console.WriteLine(names[i]);
            //}

            //int indexNum = names["jalal"];
            //Console.WriteLine(indexNum);


            #endregion

            #region CallCoordinate

            //Coordinate coordinate=new Coordinate();
            //coordinate.CoordinatesChanged += DoSomething;
            //coordinate.X = 10;
            //coordinate.Y = 20;

            #endregion

            #region SortedList
            //Lists lists=new Lists();
            //var list = lists.CreateStoredList();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Delegate

            //MyDelegate delegateMethod1= DelegateMethod1;
            //delegateMethod1.Invoke("salam man sulmazam");

            #endregion

            #region Event
            //ProcessBuildLogic processBuildLogic=new ProcessBuildLogic();
            ////processBuildLogic.ProcessCompleted += SubscribeEvent;
            //processBuildLogic.ProcessCompleted2 += SubscribeEvent2;
            //processBuildLogic.StartNotify();

            #endregion

            #region PredicateSample

            //var i = "";
            //Predicate<string> predicate = PredicateSample;
            //var result = predicate(i);
            //Console.Write(result);

            #endregion

            //for (int i = 1; i < 16; i++)
            //{
            //    fizzBuzz(i);
            //}

            #region abstract methods

            //int[] numbers=new Int32[] {1,6,4,3,3};
            //Calculator calculator=new EvenSumCalculator(numbers);

            #endregion

           
            ExecuteCreationalPatterns();
        }
            public static void fizzBuzz(int n)
            {
                bool restFive = (n % 3 == 0);
                bool restThree = (n % 5 == 0);
                if (restFive && restThree)
                {
                    Console.Write("FizzBuzz");
                }
                else if (restThree)
                {
                    Console.Write("Fizz");
                }
                else if (restFive)
                {
                    Console.Write("Buzz");
                }
                else
                {
                    Console.Write(n);
                }

            }

            private static void SubscribeEvent2(object? sender, ProcessEventArg e)
            {
                Console.WriteLine("Process Completed. "+e.IsSuccessful + " " + e.CompilationDateTime);
            }

            private static void SubscribeEvent()
            {
                Console.WriteLine("Process Completed");
            }


            private static void DoSomething(int action)
        {
            Console.WriteLine(action);
        }

            public static void DelegateMethod1(string pm)
        {
            Console.WriteLine(pm);
        }

            public static bool PredicateSample(string pm)
            {
                return string.IsNullOrEmpty(pm);
            }

            public static void ExecuteCreationalPatterns()
            {
            #region factory method
            //ProductFactory phoneFactory=new PhoneFactory();
            //IProduct phone = phoneFactory.GetFactory();

            //ProductFactory tabletFactory=new TabletFactory();
            //IProduct tablet = tabletFactory.GetFactory();
            #endregion

            #region BuilderMethod
            //ICarBuilder builder = new HondaBuilder();
            //CarBuilderDirector director = new CarBuilderDirector(builder);
            //director.Construct();

            //var car = builder.GetResult();

            #endregion

            #region Prototype Pattern

            

            #endregion
        }

    }
}
