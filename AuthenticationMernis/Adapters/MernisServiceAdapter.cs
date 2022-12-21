using AuthenticationMernis.Abstract;
using AuthenticationMernis.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MernisServiceReference.KPSPublicSoapClient;

namespace AuthenticationMernis.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            long identity = Convert.ToInt64(customer.NationalityId);
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(identity, customer.Name.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);

            bool sonuc = result.Result.Body.TCKimlikNoDogrulaResult;

            return sonuc;
        }


    }
}
