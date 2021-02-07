using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }

    }
}
