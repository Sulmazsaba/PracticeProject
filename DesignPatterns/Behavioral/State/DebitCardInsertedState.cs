using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Behavioral.State
{
   public class DebitCardInsertedState :IAtmState
    {
        public void InsertDebitCard()
        {
            Console.Write("you can not insert debit card");
        }

        public void EjectDebitCard()
        {
           Console.WriteLine("Debit Card has ejected");
        }

        public void EnterPin()
        {
            Console.WriteLine("Pin Code has Entered");
        }

        public void WithdrawMoney()
        {
            Console.Write("Take Money");
        }
    }
}
