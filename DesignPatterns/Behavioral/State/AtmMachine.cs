using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Behavioral.State
{
  public  class AtmMachine : IAtmState
    {
        public IAtmState atmState { get; set; }

        public AtmMachine()
        {
            atmState=new DebitCardInsertedState();
        }

        public void InsertDebitCard()
        {
            throw new NotImplementedException();
        }

        public void EjectDebitCard()
        {
            throw new NotImplementedException();
        }

        public void EnterPin()
        {
            throw new NotImplementedException();
        }

        public void WithdrawMoney()
        {
            throw new NotImplementedException();
        }
    }
}
