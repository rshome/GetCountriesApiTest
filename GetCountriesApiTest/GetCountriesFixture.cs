using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace GetCountriesApiTest
{

    public class CountriesFixture
    {
        public int GetCountries()
        {
            var client = new RestClient("https://restcountries.eu/");  //BaseAddress where API resides
            var request = new RestRequest("rest/v2/all", Method.GET);  //Can also do POST, DELETE methods etc

            request.RequestFormat = DataFormat.Json;  //change request format to Json

            IRestResponse response = client.Execute(request);

            HttpStatusCode statusCode = response.StatusCode;
            int numericStatusCode = (int)statusCode;

            return numericStatusCode;
        }

    }
}



