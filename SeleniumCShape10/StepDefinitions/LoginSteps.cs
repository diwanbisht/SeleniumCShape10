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
            driver.Manage().Window.Maximize();
        }

        [When(@"I enter the '([^']*)' and '([^']*)'")]
        public void WhenIEnterTheAnd(string UserNameValue, string PasswordValue)
        {
            new LoginPage(this.driver).UserLogin(UserNameValue, PasswordValue);
        }

        [Then(@"I should see the successfully login message or '([^']*)'")]
        public void ThenIShouldSeeTheSuccessfullyLoginMessageOr(string UserValue)
        {
            new LoginPage(this.driver).SuccessfullyLoginValidation(UserValue);
        }

        [When(@"I select '([^']*)'Value from Location drop down box")]
        public void WhenISelectValueFromLocationDropDownBox(string locationValue)
        {
            Thread.Sleep(2000);
            new LoginPage(this.driver).SelectLocationInformation(locationValue);
        }

        [When(@"I select '([^']*)'Value from Hotels drop down box")]
        public void WhenISelectValueFromHotelsDropDownBox(string holelVale)
        {
            new LoginPage(this.driver).SelectHotelSearch(holelVale);
        }

        [When(@"I select '([^']*)'Value from Room Type drop down box")]
        public void WhenISelectValueFromRoomTypeDropDownBox(string roomTypes)
        {
            new LoginPage(this.driver).SelectRoomTypes(roomTypes);
        }

        [When(@"I select '([^']*)' Value from Number of Rooms drop down box")]
        public void WhenISelectValueFromNumberOfRoomsDropDownBox(string numberofRooms)
        {
            new LoginPage(this.driver).SelectNumberOfRooms(numberofRooms);
        }

        [When(@"I enter '([^']*)'Value from CheckIn field")]
        public void WhenIEnterValueFromCheckInField(string checkInDate)
        {
            new LoginPage(this.driver).CheckInDate(checkInDate);
        }

        [When(@"I enter '([^']*)'Value from Chcekout field")]
        public void WhenIEnterValueFromChcekoutField(string checkOutDate)
        {
            new LoginPage(this.driver).CheckOutDate(checkOutDate);
        }

        [When(@"I select '([^']*)'Value from AdultsperRoom drop down box")]
        public void WhenISelectValueFromAdultsperRoomDropDownBox(string adultsperRoom)
        {
            new LoginPage(this.driver).AudultPerRoom(adultsperRoom);
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
            new LoginPage(driver).FirstName.SendKeys(firstName);
        }

        [When(@"I enter user Last Name as '([^']*)'")]
        public void WhenIEnterUserLastNameAs(string lastName)
        {
            new LoginPage(driver).LastName.SendKeys(lastName);
        }

        [When(@"I enter user Address as '([^']*)'")]
        public void WhenIEnterUserAddressAs(string inputAddress)
        {
            new LoginPage(driver).AddressInputArea.SendKeys(inputAddress);
        }

    
        [When(@"I enter user '([^']*)' Card Number")]
        public void WhenIEnterUserCardNumber(string carNumber)
        {
            new LoginPage(driver).EnterCardNumber.SendKeys(carNumber);
        }


        [When(@"I select '([^']*)'from the dropdwon")]
        public void WhenISelectFromTheDropdwon(string cardType)
        {
            new LoginPage(driver).CardTypesSelect.SelectByValue(cardType);
        }

        [When(@"I select Card Expiry Month as '([^']*)'")]
        public void WhenISelectCardExpiryMonthAs(string expityMonth)
        {
            new LoginPage(driver).CardExpiryMonth.SelectByText(expityMonth);
        }

        [When(@"I enter Card Expiry Year as '([^']*)'")]
        public void WhenIEnterCardExpiryYearAs(string expirYear)
        {
            new LoginPage(driver).CardExpiryYear.SelectByValue(expirYear);
        }

        [When(@"I enter enter '([^']*)' as CVV number")]
        public void WhenIEnterEnterAsCVVNumber(string cVV)
        {
            new LoginPage(driver).CVV.SendKeys(cVV);
        }

      
        [Then(@"I should be navigated to '([^']*)' Page")]
        public void ThenIShouldBeNavigatedToPage(string bookingCofirmation)
        {
           Thread.Sleep(5000);
           string bookingValue = new LoginPage(driver).BookingConfirmation.Text;
            Assert.IsTrue(bookingValue.Contains(bookingCofirmation), "Value not matched");
        }

        [Then(@"I should get the Order Number")]
        public void ThenIShouldGetTheOrderNumber()
        {
            string OrderName = new LoginPage(driver).OrderNumber.GetAttribute("value");
            if (OrderName != null)
            {
                Console.WriteLine(OrderName);
            }
           Assert.IsNotNull(OrderName);
        }



    }
}
