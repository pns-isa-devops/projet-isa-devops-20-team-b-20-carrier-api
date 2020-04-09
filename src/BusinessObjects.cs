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

        Parcel(){}

        public Parcel(string id){
            this.ParcelNumber = id;
        }

        override public string ToString()
        {
            return "CarrierRequest[ ParcelNumber " + ParcelNumber + " ]";
        }
    }
}
