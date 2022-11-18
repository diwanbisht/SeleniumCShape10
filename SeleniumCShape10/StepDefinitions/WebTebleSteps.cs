using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCShape10.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCShape10.StepDefinitions
{

    [Binding]
    public class WebTebleSteps
    {
        IWebDriver driver = new ChromeDriver();

     

        [Given(@"I Navigated to Test the WebTable")]
        public void GivenINavigatedToTestTheWebTable()
        {
            driver.Navigate().GoToUrl("https://www.w3schools.com/html/html_tables.asp");
            driver.Manage().Window.Maximize();
        }

        [When(@"I would like to get the value of Second Row")]
        public void WhenIWouldLikeToGetTheValueOfSecondRow()
        {

            new WebTableObjects(driver).GetAllRows();
        }

        [When(@"I would like to get the value of Second Column")]
        public void WhenIWouldLikeToGetTheValueOfSecondColumn()
        {
            new WebTableObjects(driver).GetAllColumns();
        }

        [Then(@"I validate the '([^']*)' contact person")]
        public void ThenIValidateTheContactPerson(string contactpersonName)
        {
            new WebTableObjects(driver).GetSpecificPersonfromtheTable(contactpersonName);
        }

        [Then(@"I validate all the values from specific columns as '([^']*)'")]
        public void ThenIValidateAllTheValuesFromSpecificColumnsAs(string columnName)
        {
            new WebTableObjects(driver).GetSpecificColuumName(columnName);
        }

        [Then(@"I validate all the values from specific columns by ColumnIndex as (.*)")]
        public void ThenIValidateAllTheValuesFromSpecificColumnsByColumnIndexAs(int columnName)
        {
            new WebTableObjects(driver).GetSpecificColuumValueByIndexNumber(1);
        }



    }
}
