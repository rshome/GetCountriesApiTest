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

        }
        
        [When(@"I receive a successful country response (.*)")]
        public void WhenIReceiveASuccessfulCountryResponse(int p0)
        {
            Assert.AreEqual(200, countries.GetCountries());
        }
        
        [Then(@"the api country response returns (.*)")]
        public void ThenTheApiCountryResponseReturns(int p0)
        {

        }
    }
}
