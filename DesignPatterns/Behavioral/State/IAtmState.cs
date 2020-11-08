using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Behavioral.State
{
   public interface IAtmState
   {
       void InsertDebitCard();
       void EjectDebitCard();
       void EnterPin();
       void WithdrawMoney();
   }
}
