using System.Net;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GetCountriesApiTest
{

    public class CountriesFixture
    {
        public int numericStatusCode { get; set; }
        public int countriesCnt { get; set; }
        HttpStatusCode statusCode;

        public void Status()
        {
            var client = new RestClient("https://restcountries.eu/");  //BaseAddress where API resides
            var request = new RestRequest("rest/v2/all", Method.GET);  //Can also do POST, DELETE methods etc

            request.RequestFormat = DataFormat.Json;  //change request format to Json

            IRestResponse response = client.Execute(request);

            //api return status code and convert to nmeric value
            statusCode = response.StatusCode;
            numericStatusCode = (int)statusCode;

            //number of countries, deserialize content of response to array
            string content = response.Content.ToString();
            JArray ja = JsonConvert.DeserializeObject<JArray>(content);

            countriesCnt = ja.Count;
        }

        //getters and setters but values already set in Status method above.
        public int SCode => numericStatusCode;

        public int CCount => countriesCnt;

    }
}



