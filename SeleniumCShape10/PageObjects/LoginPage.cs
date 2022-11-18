using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCShape10.PageObjects
{
    public class LoginPage
    {
        public IWebDriver driver;
        public LoginPage(IWebDriver driver) => this.driver = driver;

        IWebElement UserName => this.driver.FindElement(By.Name("username"));
        IWebElement Password => driver.FindElement(By.Name("password"));
        IWebElement LoginButton => driver.FindElement(By.Name("login"));
        IWebElement LoginValidation => driver.FindElement(By.Id("username_show"));

        /// <summary>
        ///         public SelectElement Location => new SelectElement(driver.FindElement(By.Id("location")));
        public SelectElement Hotel => new SelectElement(driver.FindElement(By.Id("hotels")));
        public SelectElement Room_Type => new SelectElement(driver.FindElement(By.Id("room_type")));
        public SelectElement Room_Nos => new SelectElement(driver.FindElement(By.Id("room_nos")));
        public IWebElement DatepickIn => driver.FindElement(By.Name("datepick_in"));
        public IWebElement DatepickOut => driver.FindElement(By.Name("datepick_out"));
        public SelectElement Adult_Room => new SelectElement(driver.FindElement(By.Name("adult_room")));
        public SelectElement Location => new SelectElement(driver.FindElement(By.Id("location")));

        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>

        public IWebElement FirstName => this.driver.FindElement(By.Name("first_name"));
        public IWebElement LastName => this.driver.FindElement(By.Name("last_name"));
        public IWebElement AddressInputArea => this.driver.FindElement(By.Name("address"));
        public IWebElement EnterCardNumber => this.driver.FindElement(By.Name("cc_num"));
        public SelectElement CardTypesSelect => new SelectElement(this.driver.FindElement(By.Name("cc_type")));
        public SelectElement CardExpiryYear => new SelectElement(this.driver.FindElement(By.Name("cc_exp_year")));
        public SelectElement CardExpiryMonth => new SelectElement(this.driver.FindElement(By.Name("cc_exp_month")));
        public IWebElement CVV => this.driver.FindElement(By.Name("cc_cvv"));
        public IWebElement BookingConfirmation => this.driver.FindElement(By.XPath("//tbody/tr/td[contains(text(), 'Booking Confirmation')]"));
            public IWebElement OrderNumber => this.driver.FindElement(By.Id("order_no"));

        
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
            //Room_Nos.SelectByValue(numberOfRooms.ToString());
            // Room_Nos.SelectByIndex(2);
            Room_Nos.SelectByText(numberOfRooms);
        }

        public void CheckInDate(string checkIndate)
        {
            DatepickIn.Clear();
            DatepickIn.SendKeys(checkIndate);
        }
        public void CheckOutDate(string checkOutdate)
        {
            DatepickOut.Clear();
            DatepickOut.SendKeys(checkOutdate);
        }

        public void AudultPerRoom(string adultPerRoom)
        {
            //Adult_Room.SelectByValue(adultPerRoom);
            Room_Nos.SelectByText(adultPerRoom);
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
