using System;
using System.Net;
using System.ServiceModel;
using System.Globalization;
using System.ServiceModel.Web;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using Carrier.Data;

namespace Carrier.Service
{

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
                    ConcurrencyMode = ConcurrencyMode.Single)]
    public class CarrierService : ICarrierService
    {
        public List<Parcel> parcels = new List<Parcel>();

        private void MOCK_DATA(){
            parcels.Add(new Parcel("123456789A", "1 Rue Bidon", "Colissimo", "Martine"));
            parcels.Add(new Parcel("123456789B", "2 Rue Bidon", "Colissimo", "Francis"));
            parcels.Add(new Parcel("123456789C", "3 Rue Bidon", "Colissimo", "Jean"));
            parcels.Add(new Parcel("123456789D", "4 Rue Bidon", "Colissimo", "Patrick"));
            parcels.Add(new Parcel("123456789E", "5 Rue Bidon", "Colissimo", "Florence"));
            parcels.Add(new Parcel("123456789F", "6 Rue Bidon", "Colissimo", "Lucile"));
        }

        public CarrierService()
        {
            Console.WriteLine("Start Carrier service");
            MOCK_DATA();
        }
        public string NotFound()
        {
            return "route not found";
        }

        public List<Parcel> getParcels(){
            return this.parcels;
        }

        public Parcel getParcel(string id){
            foreach(Parcel p in this.parcels){
                if(string.Equals(p.ParcelNumber, id))
                    return p;
            }
            return null;
        }

    }
}
