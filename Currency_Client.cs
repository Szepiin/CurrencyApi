using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CurrencyApi.DTO;
using Newtonsoft.Json;
using RestSharp;

namespace CurrencyApi;


public static class Currency_Client
{
    public static RestResponse ExecuteRequest(string url)
    {
        RestClient client = new RestClient();

        RestRequest request = new RestRequest();
        request.Resource = url;

        return client.Execute(request, Method.Get);
               
    }
}
