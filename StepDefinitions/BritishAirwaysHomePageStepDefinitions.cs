using BritishAirlines_SpecFlowAutomationFramework.POM;
using Microsoft.Extensions.DependencyModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Policy;

namespace BritishAirlines_SpecFlowAutomationFramework.StepDefinitions
{
    [Binding]
    public sealed class BritishAirwaysHomeStepDefinitions
    {

        private readonly BritishAirlinesPageObject _page;

        public BritishAirwaysHomeStepDefinitions(IWebDriver driver)
        {
            _page = new BritishAirlinesPageObject(driver);
        }


        [Given(@"the user is on the Browser")]
        public void GivenTheUserIsOnTheBrowser()
        {
            _page.Initiate();
        }

        [When(@"the user navigates to URL ""([^""]*)""")]
        public void WhenTheUserNavigatesToURL(string p0)
        {
            _page.Navigate(p0);
        }


        [Then(@"the user should be on the home page and title should be ""([^""]*)""")]
        public void ThenTheUserShouldBeOnTheHomePageAndTitleShouldBe(string p0)
        {
            _page.AssertTitle(p0);
        }


        [Given(@"the user is on the British Airways website")]
        public void GivenTheUserIsOnTheBritishAirwaysWebsite()
        {
            _page.Initiate();
        }

        [When(@"the user clicks on the ""([^""]*)"" link")]
        public void WhenTheUserClicksOnTheLink(string flights)
        {
            _page.Navigate(flights);
        }

        [Then(@"the user should be on the flights page")]
        public void ThenTheUserShouldBeOnTheFlightsPage()
        {
            _page.AssertTitle("");
        }

    }
}
