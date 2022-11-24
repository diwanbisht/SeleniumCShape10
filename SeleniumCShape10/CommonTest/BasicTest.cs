using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCShape10.Hooks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCShape10.CommonTest
{
    [TestFixture]
    public class BasicTest : IApplicationConfigSections
    {
        private static readonly NameValueCollection ConfigValues = ConfigurationManager.GetSection("TestConfigulation") as NameValueCollection;

        public string BaseUrl => ConfigValues["BaseUrl"];


        public string UserName
        {
            get
            {
                return ConfigValues["UserName"];
            }
        }

        public string Password => ConfigValues["Password"];

        //IWebDriver driver = new ChromeDriver();
        // IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

        public BasicTest()
        {
            //configValues = ConfigurationManager.GetSection("Locations") as NameValueCollection;
        }


        [Test]
        public void OpenBroswer()
        {
            /* driver.Navigate().GoToUrl("https://adactinhotelapp.com/");
             IWebElement UserName = driver.FindElement(By.Name("username"));
             IWebElement Password = driver.FindElement(By.Name("password"));
             IWebElement LoginButton = driver.FindElement(By.Name("login"));

             UserName.SendKeys("DiwanBisht");
             Password.SendKeys("password");
             LoginButton.Click();*/
        }



        [TearDown]
        public void CloseBrowser()
        {
            //driver.Close();
            // driver.Quit();
        }
    }
}


