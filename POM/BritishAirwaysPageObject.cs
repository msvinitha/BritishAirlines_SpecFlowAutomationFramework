using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using System.ComponentModel.DataAnnotations.Schema;

namespace BritishAirlines_SpecFlowAutomationFramework.POM
{
    public class BritishAirwaysPageObject
    {

        //The Selenium web driver to automate the browser
        private IWebDriver _webDriver;
        public BritishAirwaysPageObject(IWebDriver driver)
        {
            this._webDriver = driver;
        }

        //Finding web elements
        private IWebElement CookieAcceptButton => _webDriver.FindElement(By.XPath("//button[.='Agree to all cookies']"));
        private IWebElement MainMenuNavigations(string mainMenu) => _webDriver.FindElement(By.XPath("//a[.=' "+mainMenu+" ']"));
        private IWebElement LanguageSelection => _webDriver.FindElement(By.CssSelector(".country-language-text-long"));
        private IWebElement FooterLinks(string footer) => _webDriver.FindElement(By.XPath("//a[.='"+footer+"']"));
        private IWebElement SubTitle(string subTitles) => _webDriver.FindElement(By.XPath("//h3[.='"+subTitles+"']"));
        private IWebElement SearchButton => _webDriver.FindElement(By.CssSelector(".site-search-button"));
        private IWebElement SearchInput => _webDriver.FindElement(By.XPath("//input[@id='search-input']"));
        private IWebElement SearchResult => _webDriver.FindElement(By.XPath("//ba-entry[contains(.,'Visit Scotland | Flights, Holidays & Hotels | British Airways Discover Scotland')]"));       
        private IWebElement LoginIcon => _webDriver.FindElement(By.XPath("//span[.='Log in']"));
        private IWebElement UserID => _webDriver.FindElement(By.XPath("//input[@id='loginid']"));
        private IWebElement Password => _webDriver.FindElement(By.XPath("//input[@id='password']"));
        private IWebElement LoginButton => _webDriver.FindElement(By.XPath("//ba-button[@class='button expand-block button-solid hydrated']"));
        private IWebElement ErrorMessage => _webDriver.FindElement(By.XPath("//p[.=\"Sorry, we don't recognise those details. Please check and try again.\"]"));
        //This Element is inside single shadow DOM.
        private IWebElement From => _webDriver.FindElement(By.CssSelector("#ba-input-typeahead-0"));
        private IWebElement To => _webDriver.FindElement(By.CssSelector("#ba-input-typeahead-1"));
        private IWebElement ReturnDate => _webDriver.FindElement(By.CssSelector("[aria-label='Return']"));
        private IWebElement FindFlights => _webDriver.FindElement(By.CssSelector("#searchbar-fo-submit-button"));
        private IWebElement FlightListSummary => _webDriver.FindElement(By.XPath("//div[@class='flight-list-summary']/ba-content[@class='ng-star-inserted hydrated']"));
        private IWebElement HotelRadio => _webDriver.FindElement(By.CssSelector("[for= 'ba-radio-3']"));
        private IWebElement Destination => _webDriver.FindElement(By.CssSelector("#ba-input-typeahead-5"));
        private IWebElement FindHotels => _webDriver.FindElement(By.XPath("//button[.='Find Hotels']"));
        private IWebElement HotelListSummary => _webDriver.FindElement(By.XPath("//h1[@id='mainContentHeader']"));
        string searchTerm = "holiday";



        public void Initiate()
        {
            //    new DriverManager().SetUpDriver(new ChromeConfig());
            //ChromeOptions options = new ChromeOptions();
            //options.AddArguments("--start-maximized");
            //    _webDriver = new ChromeDriver(options);
        }

        public void Navigate(string url)
        {
            _webDriver.Navigate().GoToUrl(url);
            Thread.Sleep(3000);
            //if (CookieAcceptButton.Enabled)
            //{
            //    CookieAcceptButton.Click();
            //}
            //Thread.Sleep(4000);
            //Assert.AreEqual(LanguageSelection.Displayed, true);
        }

        public void AssertTitle(string title)
        {
            string pageTitle = _webDriver.Title;
            pageTitle.Should().Be(title);
        }

        public void AssertHome()
        {
            string currentUrl = _webDriver.Url;
            currentUrl.Should().Be("https://www.britishairways.com/travel/home/public/en_gb/");
        }

        public void SelectMenu(string mainMenu)
        {
            MainMenuNavigations(mainMenu).Click();           
        }

        public void ClickOnFooter(string footer)
        {
            FooterLinks(footer).Click();
        }

        public void ValidateDiscoverMenu()
        {
            Assert.AreEqual(SubTitle("BA").Displayed, true);
            Assert.AreEqual(SubTitle("Executive Club").Displayed, true);
            Assert.AreEqual(SubTitle("Flights and destinations").Displayed, true);
            Assert.AreEqual(SubTitle("Holidays").Displayed, true);
            Assert.AreEqual(SubTitle("Offers and deals").Displayed, true);
            Assert.AreEqual(SubTitle("Extras").Displayed, true);
        }

        public void ValidateBookMenu()
        {
            Assert.AreEqual(SubTitle("Flights").Displayed, true);
            Assert.AreEqual(SubTitle("Flights and more").Displayed, true);

        }

        public void ValidateManageMenu()
        {
            Assert.AreEqual(SubTitle("My booking").Displayed, true);
        }

        public void ValidateHelpMenu()
        {
            Assert.AreEqual(SubTitle("Customer support").Displayed, true);
            Assert.AreEqual(SubTitle("Bookings").Displayed, true);
            Assert.AreEqual(SubTitle("Assistance").Displayed, true);
            Assert.AreEqual(SubTitle("Travel news").Displayed, true);
        }
      
        public void EnterSearchTerm()
        {
            SearchButton.Click();          
            SearchInput.SendKeys(searchTerm + "\n");
        }

        public void ValidateSearchResult()
        {
            Assert.AreEqual(SearchResult.Displayed, true);
            Assert.AreEqual(SearchResult.Text.Contains(searchTerm),true);
        }

        public void EnterLoginCredentials()
        {
            LoginIcon.Click();
            UserID.SendKeys("test");
            Password.SendKeys("test");
            LoginButton.Click();
        }

        public void ValidateErrorMessage()
        {
            Assert.AreEqual(ErrorMessage.Displayed, true);
        }

        public void EnterFlightSearchDetails()
        {
            From.SendKeys("MAA");
            To.SendKeys("LON");
            ReturnDate.SendKeys("30122023");
            FindFlights.Click();
        }

        public void ValidateFlightResult()
        {
            Assert.AreEqual(FlightListSummary.Displayed, true);
        }

        public void EnterHotelSearchDetails()
        {
            
            HotelRadio.Click();
            Destination.SendKeys("LON");
            FindHotels.Click();

        }

        public void ValidateHotelResult()
        {
            Assert.AreEqual(HotelListSummary.Displayed, true);
        }

        


    }
}
