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
        public SelectElement Adult_Room => new SelectElement(driver.FindElement(By.Name("adult_room")));

        public IWebElement FirstName => this.driver.FindElement(By.Name("first_name"));
        public IWebElement LastName => this.driver.FindElement(By.Name("last_name"));
        public IWebElement AddressInputArea => this.driver.FindElement(By.Name("address"));
        public IWebElement EnterCardNumber => this.driver.FindElement(By.Name("cc_num"));
        public IWebElement CardTypes => this.driver.FindElement(By.Name("cc_type"));

        public IWebElement ExpiryYear => this.driver.FindElement(By.Name("cc_exp_year"));

        public IWebElement ExpiryMonth => this.driver.FindElement(By.Name("cc_exp_month"));

        public IWebElement CVV => this.driver.FindElement(By.Name("cc_cvv"));



        public void ClickButton(String CommonButtonName)
        {
            driver.FindElement(By.XPath("//input[@id= '" + CommonButtonName.ToString() + "' ]")).Click(); ;
        }

        public void SelectLocationInformation(string hoelLocationValue)
        {
            Location.SelectByValue(hoelLocationValue);
        }

        public void SelectHotelSearch(string hotelocationValue)
        {
            Hotel.SelectByValue(hotelocationValue);
        }
        public void SelectRoomTypes(string roomType)
        {
            Room_Type.SelectByValue(roomType);
        }
        public void SelectNumberOfRooms(string numberOfRooms)
        {
            Room_Nos.SelectByValue(numberOfRooms.ToString());
        }
        public void CheckInDate(string checkIndate)
        {
            DatepickIn.SendKeys(checkIndate);
        }
        public void CheckOutDate(string checkOutdate)
        {
            DatepickOut.SendKeys(checkOutdate);
        }

        public void AudultPerRoom(string adultPerRoom)
        {
            Adult_Room.SelectByValue(adultPerRoom);
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