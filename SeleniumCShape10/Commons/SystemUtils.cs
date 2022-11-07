using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCShape10.Commons
{
    public class SystemUtils
    {
        public static string GetChromeDriverPath()
        {
            //D:\TestAutomation\SeleniumCShape10\SeleniumCShape10\bin
            //D:\TestAutomation\SeleniumCShape10\\SeleniumCShape10\\TestData\TestFile.xlx
            string ChromeDriver = Directory.GetCurrentDirectory().Split("\\bin")[0];
            return ChromeDriver + "\\Drivers";
        }

        public string GetTestDataFile(string TestDataFileName)
        {            
            string TestDataFile = Directory.GetCurrentDirectory().Split("\\bin")[0];
           // return TestDataFile + "\\TestData";

            return TestDataFile + "\\TestData" + "\\" + TestDataFileName;
        }

        public static string [] GetAllDirectoryInfo(string DriveName)
        {
           
            //string []TestDataFile = Directory.GetDirectories(@"D:\\", "*.*", SearchOption.TopDirectoryOnly);

           //string[] TestDataFiles = Directory.GetFiles(@"D:\\", "*.*", SearchOption.TopDirectoryOnly);

            string[] TestDataFiles = Directory.GetFiles(@DriveName + "\\", "*.*", SearchOption.TopDirectoryOnly);


            return TestDataFiles;
        }

    }
}
