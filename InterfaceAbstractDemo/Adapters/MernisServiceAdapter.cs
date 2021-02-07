using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(long.Parse(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year).Result;
            return result.Body.TCKimlikNoDogrulaResult;
        }

    }
}
