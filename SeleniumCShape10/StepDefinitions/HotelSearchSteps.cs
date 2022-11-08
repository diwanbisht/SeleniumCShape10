using OpenQA.Selenium;
using SeleniumCShape10.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCShape10.StepDefinitions
{
    [Binding]
    public class HotelSearchSteps
    {
        private readonly IWebDriver driver;
        public HotelSearchSteps(IWebDriver driver) => this.driver = driver;





        [When(@"I select Hotel from drop down box")]
        public void WhenISelectHotelFromDropDownBox()
        {
            throw new PendingStepException();
        }

        [When(@"I select Room Type  from drop down box")]
        public void WhenISelectRoomTypeFromDropDownBox()
        {
            throw new PendingStepException();
        }

        [When(@"I select Number of Rooms  from drop down box")]
        public void WhenISelectNumberOfRoomsFromDropDownBox()
        {
            throw new PendingStepException();
        }


    }
}
