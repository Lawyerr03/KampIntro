using GunBesOdevBes.Abstract;
using GunBesOdevBes.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ServiceReference1.KPSPublicSoapClient;

namespace GunBesOdevBes.Adaptors
{
    public class EdevletServiceAdaptor : IGamerCheckService
    {
        bool IGamerCheckService.CheckIfRealPerson(Gamer gamer)
        {
            EndpointConfiguration configuration = new EndpointConfiguration();
            KPSPublicSoapClient kPSPublicSoapClient1 = new KPSPublicSoapClient(configuration);
            KPSPublicSoapClient kPSPublicSoapClient = kPSPublicSoapClient1;
            KPSPublicSoapClient client = kPSPublicSoapClient;
            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.TcNo), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirth.Year);
            result.Wait();
            bool sonuc = result.Result.Body.TCKimlikNoDogrulaResult;
            return sonuc;
        }
    }
}
