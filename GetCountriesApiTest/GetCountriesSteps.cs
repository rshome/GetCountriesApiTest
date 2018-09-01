using System;
using TechTalk.SpecFlow;
using NUnit;
using NUnit.Framework;

namespace GetCountriesApiTest
{
    [Binding]
    public class GetCountriesSteps
    {
        CountriesFixture countries = new CountriesFixture();

        [Given(@"I generate a restful request for countries")]
        public void GivenIGenerateARestfulRequestForCountries()
        {
            countries.Status();
        }
        
        [When(@"I receive a successful country response (.*)")]
        public void WhenIReceiveASuccessfulCountryResponse(int cresponse)
        {
            Assert.AreEqual(cresponse, countries.SCode);
        }
        
        [Then(@"the api country response returns (.*)")]
        public void ThenTheApiCountryResponseReturns(int ccount)
        {
            Assert.AreEqual(ccount, countries.countriesCnt);
        }
    }
}
