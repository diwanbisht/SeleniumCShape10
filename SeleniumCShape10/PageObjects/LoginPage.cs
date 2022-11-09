using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SeleniumCShape10.PageObjects
{
    public class LoginPage
    {
        private readonly IWebDriver driver;
        public LoginPage(IWebDriver driver) => this.driver = driver;

        IWebElement UserName => this.driver.FindElement(By.Name("username"));
        IWebElement Password => driver.FindElement(By.Name("password"));
        IWebElement LoginButton => driver.FindElement(By.Name("login"));
        IWebElement LoginValidation => driver.FindElement(By.Id("username_show"));


        public void UserLogin(string userName, string password)
        {
            UserName.SendKeys(userName);
            Password.SendKeys(password);
            LoginButton.Click();
        }
        public void SuccessfullyLoginValidation()
        {
            string expectedResult = "Hello diwanbisht!";
            string actualResult = LoginValidation.GetAttribute("value");
            Assert.AreEqual(expectedResult, actualResult, "Expected and Actual result are not matching...");
        }
        public void SuccessfullyLoginValidation(string expectedUserName)
        {
            expectedUserName = "Hello" + " " + expectedUserName + "!";
            string actualResult = LoginValidation.GetAttribute("value");
            Assert.AreEqual(expectedUserName, actualResult, "Expected and Actual result are not matching...");
        }

    }
}
