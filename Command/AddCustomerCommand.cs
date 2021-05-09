using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class AddCustomerCommand : ICommand
    {
        private CustomerService _service;

        public AddCustomerCommand(CustomerService service)
        {
            _service = service; 
        }

        public void Execute()
        {
            _service.addCustomer();
        }
    }
}
