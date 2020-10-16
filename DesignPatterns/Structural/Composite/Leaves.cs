using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Structural.Composite
{
   public class Leaves
    {

    }

   public class Espresso : Coffee
   {
       public Espresso(int calories) : base(calories)
       {
       }
   }

   public class Latte : Coffee
   {
       public Latte(int calories) : base(calories)
       {
       }
   }

   public class Cappuccino : Coffee
   {
       public Cappuccino(int calories) : base(calories)
       {
       }
   }

   public class CinnamonLatte : Coffee
   {
       public CinnamonLatte(int calories) : base(calories)
       {
       }
   }

   public class VanillaLatte : Coffee
   {
       public VanillaLatte(int calories) : base(calories)
       {
       }
   }

   public class PeppermintCappuccino : Coffee
   {
       public PeppermintCappuccino(int calories) : base(calories)
       {
       }
   }

   public class CaramelCappuccino : Coffee
   {
       public CaramelCappuccino(int calories) : base(calories)
       {
       }
   }

   public class HotCoffee : Coffee
   {
       public HotCoffee(int calories) : base(calories)
       {
       }
   }
}
