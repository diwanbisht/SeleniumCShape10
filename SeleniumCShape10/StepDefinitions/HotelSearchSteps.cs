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
    public class HotelSearchSteps : SpecflowBaseConfiguration
    {
      
       // private readonly HomePage homePage;

      
        public HotelSearchSteps(SeleniumContext seleniumContext)
            : base((BoDi.IObjectContainer)seleniumContext)
        {
           // this.homePage = new HomePage(this.Driver);
        }


    }
}
