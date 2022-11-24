using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCShape10.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SeleniumCShape10.Hooks;

namespace SeleniumCShape10.StepDefinitions
{
    [Binding]
    public class LoginSteps : BaseTestSteps
    {
        // private readonly ReportDe reportDe;
        private readonly ScenarioContext scenarioContext;

        public LoginSteps(SeleniumContext seleniumContext, ScenarioContext scenarioContext)
          : base(seleniumContext)
        {
            //this.reportDefinition = new ReportDefinition(this.Driver);
            this.scenarioContext = scenarioContext;
        }

        [Given(@"I Navigated to Test Web Site")]
        public void GivenINavigatedToTestWebSite()
        {
           this.driver.Navigate().GoToUrl("https://adactinhotelapp.com/index.php");
            driver.Manage().Window.Maximize();
        }

        [When(@"I enter the '([^']*)' and '([^']*)'")]
        public void WhenIEnterTheAnd(string UserNameValue, string PasswordValue)
        {
            new LoginPage(this.driver).UserLogin(UserNameValue, PasswordValue);
        }



    }
}
