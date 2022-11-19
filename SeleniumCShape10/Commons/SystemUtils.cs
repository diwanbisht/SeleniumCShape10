using AventStack.ExtentReports;
using OpenQA.Selenium;
using SeleniumCShape10.Hooks;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
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

        public static string[] GetAllDirectoryInfo(string DriveName)
        {

            //string []TestDataFile = Directory.GetDirectories(@"D:\\", "*.*", SearchOption.TopDirectoryOnly);

            //string[] TestDataFiles = Directory.GetFiles(@"D:\\", "*.*", SearchOption.TopDirectoryOnly);

            string[] TestDataFiles = Directory.GetFiles(@DriveName + "\\", "*.*", SearchOption.TopDirectoryOnly);


            return TestDataFiles;
        }


        public static void TakeScreenShot()
        {

            /* ITakesScreenshot screenshotDriver = seleniumContext.webDriver as ITakesScreenshot;

             Screenshot screenshot = screenshotDriver.GetScreenshot();

             screenshot.SaveAsFile("C:/test.png", OpenQA.Selenium.ScreenshotImageFormat.Png);
            */
        }

        public static MediaEntityModelProvider GetScreenshot(IWebDriver driver, string StepName)
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("document.body.style.zoom = '60%';");
            jse.ExecuteScript("window.scrollBy(0, -350)");
            var screenShot = ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;
            IJavaScriptExecutor jse1 = (IJavaScriptExecutor)driver;
            jse1.ExecuteScript("document.body.style.zoom = '100%';");
            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenShot, StepName).Build();
        }

        public static void LogFailsTest()
        {
            /*StringBuilder stringBuilder = new StringBuilder();
         

           // sb.Append("log something");
/
            File.AppendAllText("filePath" + "log.txt", stringBuilder.ToString());
            stringBuilder.Clear();*/
        }


    }
}
