using BritishAirlines_SpecFlowAutomationFramework.POM;
using Microsoft.Extensions.DependencyModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Policy;

namespace BritishAirlines_SpecFlowAutomationFramework.StepDefinitions
{
    [Binding]
    public sealed class BritishAirwaysNavigationsStepDefinitions
    {
        private BritishAirwaysPageObject _page;
        private IWebDriver driver;

        public BritishAirwaysNavigationsStepDefinitions(IWebDriver driver)
        {

            this.driver = driver;
            _page = new BritishAirwaysPageObject(this.driver);
        }

        //Scenario 2
        [Given(@"the user is on the British Airways home page")]
        public void GivenTheUserIsOnTheBritishAirwaysHomePage()
        {
            _page.AssertHome();
        }

        [When(@"the user selects main menus ""([^""]*)""")]
        public void WhenTheUserSelectsMainMenus(string mainMenu)
        {
            _page.SelectMenu(mainMenu); 
        }

        [Then(@"the user should be able to see the sublinks under Discover")]
        public void ThenTheUserShouldBeAbleToSeeTheSublinksUnderDiscover()
        {
            _page.ValidateDiscoverMenu();
        }

        [Then(@"the user should be able to see the sublinks under Book")]
        public void ThenTheUserShouldBeAbleToSeeTheSublinksUnderBook()
        {
            _page.ValidateBookMenu();
        }

        [Then(@"the user should be able to see the sublinks under Manage")]
        public void ThenTheUserShouldBeAbleToSeeTheSublinksUnderManage()
        {
            _page.ValidateManageMenu();
        }


        [Then(@"the user should be able to see the sublinks under Help")]
        public void ThenTheUserShouldBeAbleToSeeTheSublinksUnderHelp()
        {
            _page.ValidateHelpMenu();
        }






    }
}
