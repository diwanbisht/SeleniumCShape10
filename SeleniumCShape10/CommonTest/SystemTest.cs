using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCShape10.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCShape10.CommonTest
{
    public class SystemTest
    {

        [Test]
        public void DriverPathTest()
        {
            string pathvalue = SystemUtils.GetChromeDriverPath();
            Console.WriteLine(pathvalue);
        }


        [Test]
        public void GetDriveInformationTest()
        {
            var collections = SystemUtils.GetAllDirectoryInfo("C:");            
            foreach (var item in collections)
            {
                Console.WriteLine(item);
            }

        }
    }
}