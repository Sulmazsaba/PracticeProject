using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProject.DesignPatterns.Behavioral.Command
{
  public  class AddCustomerCommand : ICommand
  {
      private CustomerService _customerService;

      public AddCustomerCommand(CustomerService customerService)
      {
          _customerService = customerService;
      }

      public void Execute()
        {
            _customerService.AddCustomer();
        }
    }
}
