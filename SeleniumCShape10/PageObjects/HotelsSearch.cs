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
        public SelectElement Location => new SelectElement(driver.FindElement(By.Id("location")));
        public SelectElement Hotel => new SelectElement(driver.FindElement(By.Id("hotels")));
        public SelectElement Room_Type => new SelectElement(driver.FindElement(By.Id("room_type")));

        public SelectElement Room_Nos => new SelectElement(driver.FindElement(By.Id("room_nos")));

        public IWebElement DatepickIn => driver.FindElement(By.Name("datepick_in"));

        public IWebElement DatepickOut => driver.FindElement(By.Name("datepick_out"));

        public IWebElement Adult_Room => driver.FindElement(By.Name("adult_room"));


        
       

        public void ClickButton(String CommonButtonName)
        {
            driver.FindElement(By.XPath("//input[@id= '" + CommonButtonName.ToString() + "' ]")).Click(); ;
        }

        public void SelectLocationInformation(string hoelLocationValue)
        {
            Location.SelectByValue(hoelLocationValue);
        }

        public void HotelSearch(string hoelLocationValue)
        {
            Hotel.SelectByValue(hoelLocationValue);
        }

        public void PrintingAnyDropDownItems(SelectElement anydropdownList)
        {
            List<IWebElement> listcollection = new List<IWebElement>(anydropdownList.Options).ToList();

            foreach (var item in listcollection)
            {
                Console.WriteLine(item.Text);
            }

        }

    }
}