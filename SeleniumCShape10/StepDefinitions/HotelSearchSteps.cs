using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumCShape10.Hooks;
using SeleniumCShape10.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCShape10.StepDefinitions
{
    [Binding]
    public class HotelSearchSteps : BaseTestSteps
    {
        private readonly HotelsSearch hotelSearch;

        public HotelSearchSteps(SeleniumContext seleniumContext)
            : base((SeleniumContext)(BoDi.IObjectContainer)seleniumContext)
        {
           this.hotelSearch = new HotelsSearch(driver);
        }
        /// <summary>
        ///         public SelectElement Location => new SelectElement(driver.FindElement(By.Id("location")));
        public SelectElement Hotel => new SelectElement(driver.FindElement(By.Id("hotels")));
        public SelectElement Room_Type => new SelectElement(driver.FindElement(By.Id("room_type")));
        public SelectElement Room_Nos => new SelectElement(driver.FindElement(By.Id("room_nos")));
        public IWebElement DatepickIn => driver.FindElement(By.Name("datepick_in"));
        public IWebElement DatepickOut => driver.FindElement(By.Name("datepick_out"));
        public SelectElement Adult_Room => new SelectElement(driver.FindElement(By.Name("adult_room")));
        public SelectElement Location => new SelectElement(driver.FindElement(By.Id("location")));

       
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




        [Then(@"I should see the successfully login message or '([^']*)'")]
        public void ThenIShouldSeeTheSuccessfullyLoginMessageOr(string UserValue)
        {
            new LoginPage(this.driver).SuccessfullyLoginValidation(UserValue);
        }

        [When(@"I select '([^']*)'Value from Location drop down box")]
        public void WhenISelectValueFromLocationDropDownBox(string locationValue)
        {
            Thread.Sleep(2000);
            new HotelsSearch(this.driver).SelectLocationInformation(locationValue);
        }

        [When(@"I select '([^']*)'Value from Hotels drop down box")]
        public void WhenISelectValueFromHotelsDropDownBox(string holelVale)
        {
            new HotelsSearch(this.driver).SelectHotelSearch(holelVale);
        }

        [When(@"I select '([^']*)'Value from Room Type drop down box")]
        public void WhenISelectValueFromRoomTypeDropDownBox(string roomTypes)
        {
            new HotelsSearch(this.driver).SelectRoomTypes(roomTypes);
        }

        [When(@"I select '([^']*)' Value from Number of Rooms drop down box")]
        public void WhenISelectValueFromNumberOfRoomsDropDownBox(string numberofRooms)
        {
            new HotelsSearch(this.driver).SelectNumberOfRooms(numberofRooms);
        }

        [When(@"I enter '([^']*)'Value from CheckIn field")]
        public void WhenIEnterValueFromCheckInField(string checkInDate)
        {
            new HotelsSearch(this.driver).CheckInDate(checkInDate);
        }

        [When(@"I enter '([^']*)'Value from Chcekout field")]
        public void WhenIEnterValueFromChcekoutField(string checkOutDate)
        {
            new HotelsSearch(this.driver).CheckOutDate(checkOutDate);
        }

        [When(@"I select '([^']*)'Value from AdultsperRoom drop down box")]
        public void WhenISelectValueFromAdultsperRoomDropDownBox(string adultsperRoom)
        {
            new HotelsSearch(this.driver).AudultPerRoom(adultsperRoom);
        }

        [When(@"I click on '([^']*)' button")]
        public void WhenIClickOnButton(string anyButton)
        {
            new LoginPage(driver).ClickButton(anyButton);
            Thread.Sleep(2000);
        }

        [When(@"I enter user First Name as '([^']*)'")]
        public void WhenIEnterUserFirstNameAs(string firstName)
        {
            new HotelsSearch(driver).FirstName.SendKeys(firstName);
        }

        [When(@"I enter user Last Name as '([^']*)'")]
        public void WhenIEnterUserLastNameAs(string lastName)
        {
            new HotelsSearch(driver).LastName.SendKeys(lastName);
        }

        [When(@"I enter user Address as '([^']*)'")]
        public void WhenIEnterUserAddressAs(string inputAddress)
        {
            new HotelsSearch(driver).AddressInputArea.SendKeys(inputAddress);
        }


        [When(@"I enter user '([^']*)' Card Number")]
        public void WhenIEnterUserCardNumber(string carNumber)
        {
            new HotelsSearch(driver).EnterCardNumber.SendKeys(carNumber);
        }

        [When(@"I select '([^']*)'from the dropdwon")]
        public void WhenISelectFromTheDropdwon(string cardType)
        {
           // new HotelsSearch(driver).CardTypes.SelectByValue(cardType);
        }

        [When(@"I select Card Expiry Month as '([^']*)'")]
        public void WhenISelectCardExpiryMonthAs(string expityMonth)
        {
           // new LoginPage(driver).CardExpiryMonth.SelectByText(expityMonth);
        }

        [When(@"I enter Card Expiry Year as '([^']*)'")]
        public void WhenIEnterCardExpiryYearAs(string expirYear)
        {
            //new HotelsSearch(driver).CardExpiryYear.SelectByValue(expirYear);
        }

        [When(@"I enter enter '([^']*)' as CVV number")]
        public void WhenIEnterEnterAsCVVNumber(string cVV)
        {
            new HotelsSearch(driver).CVV.SendKeys(cVV);
        }


        [Then(@"I should be navigated to '([^']*)' Page")]
        public void ThenIShouldBeNavigatedToPage(string bookingCofirmation)
        {
            Thread.Sleep(5000);
           // string bookingValue = new HotelsSearch(driver).BookingConfirmation.Text;
           // Assert.IsTrue(bookingValue.Contains(bookingCofirmation), "Value not matched");
        }

        [Then(@"I should get the Order Number")]
        public void ThenIShouldGetTheOrderNumber()
        {
           /* string OrderName = new HotelsSearch(driver).OrderNumber.GetAttribute("value");
            if (OrderName != null)
            {
                Console.WriteLine(OrderName);
            }
            Assert.IsNotNull(OrderName);*/
        }


    }
}
