using OpenQA.Selenium;
using TechTalk.SpecFlow;
using System;
using System.Configuration;
using System.Threading;
using NUnit.Framework;

namespace CrossBrowserTests.Steps
{

    [Binding]
    public class SearchProducts : Hooks
    {

        string WebServer { get { return ConfigurationManager.AppSettings["WebServer"]; } }

        [Given(@"I go to the Genie Solutions web page")]
        public void GivenIGoToTheGenieSolutionsWebPage()
        {
            Driver.Navigate().GoToUrl(WebServer);
            Driver.Manage().Window.Maximize();

        }

        [When(@"I search for '(.*)' prodcuts")]
        public void WhenISearchForProdcuts(string product)
        {
            Driver.FindElement(By.Id("Layer_1")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("s")).SendKeys(product);
            Thread.Sleep(2000);
            Driver.FindElement(By.Id("searchsubmit")).Click();
            Thread.Sleep(2000);
        }

        [Then(@"Verify search results includes '(.*)' products")]
        public void ThenVerifySearchResultsIncludesProducts(string p0)
        {
            Assert.AreEqual(true, Driver.FindElement(By.ClassName("search-post")).Displayed);
        }

    }
}
