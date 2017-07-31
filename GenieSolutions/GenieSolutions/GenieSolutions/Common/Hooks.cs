using System.IO;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Remote;

namespace CrossBrowserTests
{
    [Binding]
    public class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks



        protected static RemoteWebDriver Driver { get; set; }

        
        [BeforeScenario]
        public static void BeforeScenario()
        {
            Driver = new ChromeDriver();
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            Driver.Dispose();
               
        }
        
    }
}
