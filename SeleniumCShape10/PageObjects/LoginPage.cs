using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCShape10.PageObjects
{
    public class LoginPage
    {
        IWebDriver driver = new ChromeDriver();
        public LoginPage(IWebDriver driver)
        {

        }
        IWebElement UserName => driver.FindElement(By.Name("username"));
        IWebElement Password => driver.FindElement(By.Name("password"));
        IWebElement LoginButton => driver.FindElement(By.Name("login"));


        public void UserLogin(string userName, string password)
        {
            UserName.SendKeys(userName);
            Password.SendKeys(password);
            LoginButton.Click();


        }
       


    }
}
