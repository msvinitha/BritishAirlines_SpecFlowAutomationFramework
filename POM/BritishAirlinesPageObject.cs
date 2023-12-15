using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BritishAirlines_SpecFlowAutomationFramework.POM
{
    public class BritishAirlinesPageObject
    {

        //The Selenium web driver to automate the browser
        private readonly IWebDriver _webDriver;

        public BritishAirlinesPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        //Finding elements by ID
        private IWebElement FirstNumberElement => _webDriver.FindElement(By.Id("first-number"));

        public void Initiate()
        {
            //_webDriver = new ChromeDriver();
        }

        public void Navigate(string url)
        {
            _webDriver.Navigate().GoToUrl(url);
        }

        public void AssertTitle(string title)
        {
            string pageTitle = _webDriver.Title;
            pageTitle.Should().Be(title);
        }
    }
}
