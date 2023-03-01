using InterfaceAbstractDemo.Abstract;
using MernisServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MernisServiceReference1.KPSPublicSoapClient;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            EndpointConfiguration configuration= new EndpointConfiguration();
            KPSPublicSoapClient kPSPublicSoapClient1 = new KPSPublicSoapClient(configuration);
            KPSPublicSoapClient kPSPublicSoapClient = kPSPublicSoapClient1;
            KPSPublicSoapClient client = kPSPublicSoapClient;
            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.Firstname.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
            result.Wait();
            bool sonuc = result.Result.Body.TCKimlikNoDogrulaResult;
            return sonuc;

        }
    }
}
