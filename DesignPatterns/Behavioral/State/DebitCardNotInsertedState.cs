using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Behavioral.State
{
   public class DebitCardNotInsertedState :IAtmState
    {
        public void InsertDebitCard()
        {
            Console.WriteLine("Debit Card has inserted");
        }

        public void EjectDebitCard()
        {
           Console.WriteLine("You can not eject the Debit Card");
        }

        public void EnterPin()
        {
            Console.WriteLine("You Can not enter pin code");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("You can not with draw money");
        }
    }
}
