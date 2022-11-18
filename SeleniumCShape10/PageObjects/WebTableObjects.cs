using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCShape10.PageObjects
{
    public class WebTableObjects
    {
        public IWebDriver driver;
        public WebTableObjects(IWebDriver driver) => this.driver = driver;

        IWebElement Table => this.driver.FindElement(By.XPath("//table/tbody"));
        List<IWebElement> TableRows => this.driver.FindElements(By.XPath("//table/tbody/tr")).ToList();
        List<IWebElement> TableColumns => this.driver.FindElements(By.XPath("//table/tbody/tr/td")).ToList();
        IWebElement TableSpecificColumn => this.driver.FindElement(By.XPath("//table/tbody/tr[3]/td[2])[2]"));

        public void GetAllRows()
        {
            List<IWebElement> TableRowLists = Table.FindElements(By.TagName("/tr")).ToList();

            foreach (var item in TableRowLists)
            {
                Console.WriteLine(item.Text);
                Console.WriteLine("Number of Row in the Table are " + TableRowLists.Count);
            }
        }

        public void GetAllColumns()
        {
            List<IWebElement> ColumnsList = TableRows;

            foreach (var item in ColumnsList)
            {
                Console.WriteLine(item.Text);
                Console.WriteLine("Number of Columns in the Table are " + ColumnsList.Count);
            }
        }

        public void GetSpecificPersonfromtheTable(string personName)
        {
            List<IWebElement> ColumnsList = TableColumns;

            foreach (var item in ColumnsList)
            {
                if (item.Text == personName)
                {
                    Console.WriteLine(item.Text + "is equal to " + personName);
                    string value = item.Text;
                    break;
                }
            }
        }

        public void GetSpecificColuumValueByIndexNumber(int colNumber)
        {
            List<IWebElement> ColumnsList = this.driver.FindElements(By.XPath("//table/tbody/tr/td" + "[" + colNumber + "]")).ToList(); ;

            foreach (var item in ColumnsList)
            {
                Console.WriteLine(item.Text);
            }
        }

        public void GetSpecificColuumName(string columnName)
        {
            List<IWebElement> ColumnsNameLists = this.driver.FindElements(By.XPath("//table/tbody/tr/th")).ToList();
            
            int colIndex = 0;

            for (int i = 0; i < ColumnsNameLists.Count; i++)
            {
                if (ColumnsNameLists[i].Text == columnName)
                {
                    colIndex = i + 1; //get the Column Inxex
                    break;
                }
            }

            List<IWebElement> SpecificColumnsValues = this.driver.FindElements(By.XPath("//table/tbody/tr/td" + "[" + colIndex + "]")).ToList();

            foreach (var item in SpecificColumnsValues)
            {
                Console.WriteLine(columnName + "===Column Name" + "Column Items values are ===" + "   " +  item.Text);
            }
        }
    }
}