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
            parcels.Add(new Parcel("123456789A", "Instant travel", "Colissimo", "Martine"));
            parcels.Add(new Parcel("123456789B", "5 rue Vert", "Colissimo", "Francis"));
            parcels.Add(new Parcel("123456789C", "10 rue Orange", "Colissimo", "Jean"));
            parcels.Add(new Parcel("123456789D", "900 rue Rouge", "Colissimo", "Patrick"));
            parcels.Add(new Parcel("123456789E", "900 rue Rouge", "Colissimo", "Florence"));
            parcels.Add(new Parcel("123456789F", "5 rue Vert", "Colissimo", "Lucile"));
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
