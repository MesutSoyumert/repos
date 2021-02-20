using Gun_05_Odev_05.Abstract;
using Gun_05_Odev_05.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun_05_Odev_05.Adapters
{
    public class MernisServiceAdapter : IGamersCheckService
    {
        public bool CheckIfRealPerson(Gamers gamers)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            long TCKimlikNo = gamers.NationalityId;
            string Ad = gamers.FirstName.ToUpper();
            string Soyad = gamers.LastName.ToUpper();
            int DogumYili = gamers.DateOfBirth.Year;


            return false;
            //return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(
               // TCKimlikNo, Ad, Soyad, DogumYili))).Result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
