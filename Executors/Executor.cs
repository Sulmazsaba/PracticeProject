using System;
using PracticeProject.DesignPatterns.Behavioral.State2;
using PracticeProject.DesignPatterns.CreationalPatterns.Abstract;
using PracticeProject.DesignPatterns.CreationalPatterns.Builder2;
using PracticeProject.DesignPatterns.Structural.Decorator;

namespace PracticeProject.Executors
{
    public delegate void MyDelegate(string pm);
  public static  class Executor
    {
        
        private static DateTime nwDateTime;
        //private IAbstractFactory _abstractFactory;
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

            //Employee employee1=new Employee();
            //employee1.FirstName = "Sulmaz";
            //employee1.LastName = "saba";
            //employee1.Department = "IT";
            //employee1.Address=new Address()
            //{
            //    StreetName = "Shariati"
            //};

            //Employee employee2 = (Employee) employee1.Clone();
            //employee2.Address.StreetName = "Navab";

            #endregion

            #region Singleton

            //MySingleton singleton1 = MySingleton.Instance();
            //MySingleton singleton2=MySingleton.Instance();
            //if(singleton2!=singleton1)
            //    Console.WriteLine("two instances are different");
            #endregion

            #region Abstract

            
            var builder=new ConcreteBuilder();
            Director director=new Director();
            director.Builder = builder;

            director.buildMaximumFeature();
            Console.WriteLine(builder.GetProduct().ListParts());

            director.buildMinimalFeature();
            Console.WriteLine(builder.GetProduct().ListParts());

            #endregion
        }

            public static void CallAbstractFactory(IAbstractFactory abstractFactory)
            {
                var productA = abstractFactory.CreateProductA();
               Console.WriteLine(productA.UsefulFunctionA());
               var productB = abstractFactory.CreateProductB();
               Console.WriteLine(productB.UsefulFunctionB());
               Console.WriteLine(productB.AnotherUsefulFunctionB(productA));

            }

            public static void ExecuteStructuralPatterns()
            {
            #region Adapter

            //ITarget target=new EmployeeAdapter();
            //    foreach (var employee in target.GetEmployees())
            //    {
            //        Console.WriteLine(employee);
            //    }


            #endregion

            #region Composite Pattern

            //Latte latte=new Latte(200);
            //latte.Flavors.Add(new CinnamonLatte(300));
            //latte.Flavors.Add(new VanillaLatte(250));

            //Espresso espresso=new Espresso(500);

            //Cappuccino cappuccino=new Cappuccino(400);
            //cappuccino.Flavors.Add(new CaramelCappuccino(430));
            //cappuccino.Flavors.Add(new PeppermintCappuccino(390));

            //HotCoffee hotCoffee=new HotCoffee(460);
            //hotCoffee.Flavors.Add(latte);
            //hotCoffee.Flavors.Add(espresso);
            //hotCoffee.Flavors.Add(cappuccino);

            //hotCoffee.DisplayCalories();
            #endregion

            #region Decorator
            Pizza pepperoni=new Pepperoni();
            Console.WriteLine(pepperoni.GetDescription() + " Cost: " + pepperoni.GetCost());
            
            pepperoni=new Onion(pepperoni);
            pepperoni=new Cheese(pepperoni);
            Console.WriteLine(pepperoni.GetDescription() + " Cost: " + pepperoni.GetCost());

            #endregion

        }

            public static void ExecuteBehavioralPatterns()
            {
            #region Observer

            //BlogReader sam = new BlogReader("sam");
            //BlogReader kian = new BlogReader("kian");

            //BlogWriter writer = new BlogWriter();
            //writer.AddReader(sam);
            //writer.AddReader(kian);

            //writer.Notify("salam bacheha biayn berim birun");

            //Console.WriteLine(Environment.NewLine);
            //writer.Notify("nemiayn??");

            #endregion

            #region Strategy

           // Dictionary<string,IMathOperator> strategies=new Dictionary<string, IMathOperator>();
           // strategies.Add("+",new MathAdd());
           // //strategies.Add("-",new);

           // IMathOperator strategy= strategies["+"];
           //var result= strategy.Operation(2, 7);
           // Console.WriteLine(result);
            #endregion

            #region Momento
            //Editor editor=new Editor();
            //EditorHistory history=new EditorHistory();

            //editor.Content = "a";
            //history.Push(editor.CreateState());

            //editor.Content = "b";
            //history.Push(editor.CreateState());

            //editor.Content = "c";
            //editor.RestoreState(history.Pop());

            //Console.WriteLine(editor.Content);

            #endregion

            #region State2
            Canvas canvas=new Canvas();
            canvas.CurrentTool=new SelectionTool();
            canvas.MouseDown();
            canvas.MouseUp();

            canvas.CurrentTool=new BrushTool();
            canvas.MouseDown();
            canvas.MouseUp();

            #endregion
        }

            public static void ExecuteLinqOperators()
            {
               LinqOperators.GroupJoin();
            }

            public static void ExecuteIndexer()
            {

            IndexedNames names = new IndexedNames();
            names[0] = "sulmaz";
            names[1] = "ahmad";
            names[2] = "javad";
            names[7] = "navid";
            names[3] = "jalal";

            for (int i = 0; i < IndexedNames.ArraySize; i++)
            {

                Console.WriteLine(names[i]);
            }

            int indexNum = names["jalal"];
            Console.WriteLine(indexNum);
        }

            public static void CallCoordinate()
            {
            Coordinate coordinate = new Coordinate();
            coordinate.CoordinatesChanged += DoSomething;
            coordinate.X = 10;
            coordinate.Y = 20;
        }

            public static void SortedList()
            {

            Lists lists = new Lists();
            var list = lists.CreateStoredList();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

            public static void Delegate()
            {

            MyDelegate delegateMethod1 = DelegateMethod1;
            delegateMethod1.Invoke("salam man sulmazam");
        }

            public static void Event()
            {

            ProcessBuildLogic processBuildLogic = new ProcessBuildLogic();
            processBuildLogic.ProcessCompleted += SubscribeEvent;
            processBuildLogic.ProcessCompleted2 += SubscribeEvent2;
            processBuildLogic.StartNotify();
        }

            public static void PredicateSample()
            {

            var i = "";
            Predicate<string> predicate = PredicateSample;
            var result = predicate(i);
            Console.Write(result);
        }

            public static void AbstractMethod()
            {

            int[] numbers = new Int32[] { 1, 6, 4, 3, 3 };
            Calculator calculator = new EvenSumCalculator(numbers);
        }
    }
}
