using BritishAirlines_SpecFlowAutomationFramework.POM;
using Microsoft.Extensions.DependencyModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V117.Browser;
using System;
using System.Security.Policy;

namespace BritishAirlines_SpecFlowAutomationFramework.StepDefinitions
{
    [Binding]
    public sealed class BritishAirwaysFunctionalityStepDefinitions
    {
        
        private IWebDriver driver;
        BritishAirwaysPageObject _pageObj;

        public BritishAirwaysFunctionalityStepDefinitions(IWebDriver driver)
        {
            
            this.driver = driver;
        }


        //Scenario 1  
        [Given(@"the user is on the British Airways website")]
        public void GivenTheUserIsOnTheBritishAirwaysWebsite()
        {
            _pageObj = new BritishAirwaysPageObject(driver);
            _pageObj.Initiate();        
        }

        [When(@"the user enters a destination and clicks on the search button")]
        public void WhenTheUserEntersADestinationAndClicksOnTheSearchButton()
        {
            _pageObj.EnterSearchTerm();
        }

        [Then(@"the user should see relevant search results")]
        public void ThenTheUserShouldSeeRelevantSearchResults()
        {
            _pageObj.ValidateSearchResult();
        }

        //Scenario 2
        [When(@"the user clicks on the Login link and enters invalid credentials")]
        public void WhenTheUserClicksOnTheLoginLinkAndEntersInvalidCredentials()
        {
            _pageObj.EnterLoginCredentials();
        }

        [Then(@"the user should be shown error message")]
        public void ThenTheUserShouldBeShownErrorMessage()
        {
            _pageObj.ValidateErrorMessage();
        }

        //Scenario 3
        [When(@"the user selects a destination, date, and click Search Flights button")]
        public void WhenTheUserSelectsADestinationDateAndClickSearchFlightsButton()
        {
            _pageObj.EnterFlightSearchDetails();
        }

        [Then(@"the user should see available flights and pricing options")]
        public void ThenTheUserShouldSeeAvailableFlightsAndPricingOptions()
        {
            _pageObj.ValidateFlightResult();
        }

        [When(@"the user selects a destination, date, and click Find Hotels button")]
        public void WhenTheUserSelectsADestinationDateAndClickFindHotelsButton()
        {
            _pageObj.EnterHotelSearchDetails();
        }

        [Then(@"the user should see available Hotels and pricing options")]
        public void ThenTheUserShouldSeeAvailableHotelsAndPricingOptions()
        {
            _pageObj.ValidateHotelResult();
        }




    }
}
