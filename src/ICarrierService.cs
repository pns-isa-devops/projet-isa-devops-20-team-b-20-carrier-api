using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Collections.Generic;

using Carrier.Data;

namespace Carrier.Service
{

    [ServiceContract]
    public interface ICarrierService
    {

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "carrier/parcel/{id}",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json)]
        Parcel getParcel(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "carrier/parcel",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json)]
        List<Parcel> getParcels();

        // catch all the other requests
        [OperationContract]
        [WebGet(UriTemplate = "*",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json)]
        string NotFound();
    }

}
