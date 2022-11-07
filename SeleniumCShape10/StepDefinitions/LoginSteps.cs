using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCShape10.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCShape10.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        IWebDriver driver = new ChromeDriver();


        [Given(@"I Navigated to Test Web Site")]
        public void GivenINavigatedToTestWebSite()
        {
            driver.Navigate().GoToUrl("https://adactinhotelapp.com/index.php");
        }

        [When(@"I enter the '([^']*)' and '([^']*)'")]
        public void WhenIEnterTheAnd(string UserNameValue, string PasswordValue)
        {
            new LoginPage(this.driver).UserLogin(UserNameValue, PasswordValue);
        }


        [Then(@"I should see the successfully login message or User")]
        public void ThenIShouldSeeTheSuccessfullyLoginMessageOrUser()
        {
            throw new PendingStepException();
        }

    }
}
