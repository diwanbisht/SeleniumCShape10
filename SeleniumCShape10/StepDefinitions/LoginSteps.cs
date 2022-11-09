using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCShape10.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
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

        [Then(@"I should see the successfully login message or '([^']*)'")]
        public void ThenIShouldSeeTheSuccessfullyLoginMessageOr(string UserValue)
        {
            new LoginPage(this.driver).SuccessfullyLoginValidation(UserValue);
        }

        [When(@"I select '([^']*)' from drop down box")]
        public void WhenISelectFromDropDownBox(string locationValue)
        {
            new HotelsSearch(this.driver).SelectLocationInformation(locationValue);
        }

        [When(@"I select Hotel from drop down box")]
        public void WhenISelectHotelFromDropDownBox()
        {
            new HotelsSearch(this.driver).HotelSearch("Hotel Creek");
        }

        [When(@"I select Room Type  from drop down box")]
        public void WhenISelectRoomTypeFromDropDownBox()
        {
            
        }

        [When(@"I select Number of Rooms  from drop down box")]
        public void WhenISelectNumberOfRoomsFromDropDownBox()
        {
            throw new PendingStepException();
        }

        [When(@"I enter CheckIndate")]
        public void WhenIEnterCheckIndate()
        {
            throw new PendingStepException();
        }

        [When(@"I enter CheckOutDate")]
        public void WhenIEnterCheckOutDate()
        {
            throw new PendingStepException();
        }



    }
}
