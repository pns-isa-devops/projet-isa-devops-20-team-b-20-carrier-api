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
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string Carrier { get; set; }
        [DataMember]
        public string CustomerName { get; set; }

        Parcel(){}

        public Parcel(string id, string Address, string Carrier, string CustomerName){
            this.ParcelNumber = id;
            this.Address = Address;
            this.Carrier = Carrier;
            this.CustomerName = CustomerName;
        }

        override public string ToString()
        {
            return "CarrierRequest[ ParcelNumber " + ParcelNumber + " ]";
        }
    }
}
