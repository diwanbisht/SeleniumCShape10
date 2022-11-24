using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCShape10.Commons;
using SeleniumCShape10.PageObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;


namespace SeleniumCShape10.Hooks
{

    public class SeleniumContext
    {
        public SeleniumContext(IWebDriver _WebDriver)
        {
            this._WebDriver = _WebDriver;
            //this.CreateChromeDriver();
        }      
        public IWebDriver _WebDriver { get; set; }

        public void CreateChromeDriver()
        {
            // IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddUserProfilePreference("download.default_directory", (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)));
            //IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            options.AddArgument("--incognito");
            this._WebDriver = new ChromeDriver(options);
            LoginToApplication();
        }

        public void QuitDriver()
        {
            this._WebDriver.Quit();
        }

        public void LoginToApplication()
        {
            ExcelHelpers helper = new ExcelHelpers();
            Dictionary<string, string> dicValues = helper.ReadExcelRowByRow(1);

            string BaseUrlfromExcel = dicValues["BaseUrl"];
            string UserName = dicValues["UserName"];
            string passwrod = dicValues["Password"];
            
            this._WebDriver.Navigate().GoToUrl(BaseUrlfromExcel.ToString());
           
            new LoginPage(_WebDriver).UserLogin(UserName, passwrod);

        }
    }
}

