using System.Runtime.Serialization;
using System;

namespace Carrier.Data
{
    [DataContract(Namespace = "http://carrier/external/request/data/",
                  Name = "Parcel")]
    public class Parcel
    {
        [DataMember]
        public string ParcelNumber { get; set; }
        public string Address { get; set; }
        public string Carrier { get; set; }
        public string CustomerName { get; set; }

        Parcel(){}

        public Parcel(string id, string Address, string Carrier, string CustomerName){
            this.ParcelNumber = id;
        }

        override public string ToString()
        {
            return "CarrierRequest[ ParcelNumber " + ParcelNumber + " ]";
        }
    }
}
