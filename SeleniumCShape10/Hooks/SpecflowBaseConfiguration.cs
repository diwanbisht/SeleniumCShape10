using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using BoDi;
using log4net;
using OpenQA.Selenium;
using SeleniumCShape10.Commons;

namespace SeleniumCShape10.Hooks
{
    [Binding]
    public class SpecflowBaseConfiguration
    {
        private static SeleniumContext seleniumContext;
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        private readonly IObjectContainer objectContainer;

        public SpecflowBaseConfiguration(IObjectContainer container)
        {
            this.objectContainer = container;
        }

        [AfterScenario]
        public static void Takescreenshot()
        {
            SystemUtils.TakeScreenShot();
        }

        [BeforeFeature]
        [Obsolete("Replaced by the automatic starter")]
        public static void BeforeFeature()
        {
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
        }


        [BeforeTestRun]
        [Obsolete("Replaced by the automatic starter")]
        public static void RunBeforeAllTests()
        {
            string path = "C:\\QA Reports\\path\\" + "ExtendReport_" + DateTime.Now.ToString("MM_dd_HH_mm") + ".html";
            ExtentV3HtmlReporter htmlReporter = new ExtentV3HtmlReporter(path);
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
           // new SeleniumContext(_WebDriver).LoginToApplication();
        }


        [AfterTestRun]
        public static void RunAfterAllTests()
        {
            seleniumContext.QuitDriver();
            extent.Flush();
        }


        [BeforeScenario]
        [Obsolete("Replaced by the automatic starter")]
        public void RunBeforeScenario()
        {
            scenario = featureName.CreateNode<AventStack.ExtentReports.Gherkin.Model.Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
            this.objectContainer.RegisterInstanceAs<SeleniumContext>(seleniumContext);
        }


        [AfterStep]
        [Obsolete("Replaced by the automatic starter")]
        public void InsertReportingSteps()
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                {
                    scenario.CreateNode<Given>("Given " + ScenarioStepContext.Current.StepInfo.Text);
                }
                else if (stepType == "When")
                {
                    scenario.CreateNode<When>("When " + ScenarioStepContext.Current.StepInfo.Text);
                }
                else if (stepType == "Then")
                {
                    scenario.CreateNode<Then>("Then " + ScenarioStepContext.Current.StepInfo.Text);
                }
                else if (stepType == "And")
                {
                    scenario.CreateNode<And>("And " + ScenarioStepContext.Current.StepInfo.Text);
                }
            }
            else if (ScenarioContext.Current.TestError != null)
            {
                ILog log = LogManager.GetLogger(typeof(SpecFlowContext));
                var screenshot = SystemUtils.GetScreenshot(seleniumContext._WebDriver, ScenarioContext.Current.ScenarioInfo.Title.Trim());
                var referenceMessage = ScenarioContext.Current.TestError.Message + log + "<br /> <b> User: </b>" + "<br /> <b>URL: </b>" + seleniumContext._WebDriver.Url.ToString();

                if (stepType == "Given")
                {
                    scenario.CreateNode<Given>("Given " + ScenarioStepContext.Current.StepInfo.Text).Fail(referenceMessage, screenshot);
                }
                else if (stepType == "When")
                {
                    scenario.CreateNode<When>("When " + ScenarioStepContext.Current.StepInfo.Text).Fail(referenceMessage, screenshot);
                }
                else if (stepType == "Then")
                {
                    scenario.CreateNode<Then>("Then " + ScenarioStepContext.Current.StepInfo.Text).Fail(referenceMessage, screenshot);
                }
                else if (stepType == "And")
                {
                    scenario.CreateNode<And>("And " + ScenarioStepContext.Current.StepInfo.Text).Fail(referenceMessage, screenshot);
                }
            }
        }
    }
}