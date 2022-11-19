using OpenQA.Selenium;
using SeleniumCShape10.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCShape10.StepDefinitions
{
    [Binding]
    public class BaseTestSteps
    {

        private readonly SeleniumContext seleniumContext;


        public BaseTestSteps(SeleniumContext seleniumContext)
        {
            this.seleniumContext = seleniumContext;
        }

        protected IWebDriver driver
        {
            get { return this.seleniumContext._WebDriver; }
        }
    }
}