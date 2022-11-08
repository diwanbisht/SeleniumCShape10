using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCShape10.PageObjects
{
    public class HotelsSearch
    {
        IWebDriver driver = new ChromeDriver();

        public HotelsSearch(IWebDriver driver) => this.driver = driver;
      
    
        SelectElement Location => new SelectElement(driver.FindElement(By.Id("location")));


        public void SelectSearchHotelInformation(string hoelLocationValue)
        {
            Location.SelectByValue(hoelLocationValue);
        }
    }
}