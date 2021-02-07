using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());

            customerManager.Save(new Entities.Customer { DateOfBirth = new DateTime(1998,6,24), FirstName = "FATİH", LastName = "ÜNVANLI", NationalityId = "52966685210" });

            Console.ReadLine();
        }
    }
}
