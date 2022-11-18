using OpenQA.Selenium;
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
    public class HotelSearchSteps : BaseConfiguration
    {
        private readonly IWebDriver driver;
        public HotelSearchSteps(IWebDriver driver) => this.driver = driver;


    }
}
