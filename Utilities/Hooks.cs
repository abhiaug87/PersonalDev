using PersonalDev.Stepdefinitions;
using System.Linq;
using TechTalk.SpecFlow;
using System;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System.IO;
using OpenQA.Selenium.Support.Extensions;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using System.Reflection;

namespace PersonalDev.Utilities
{
    [Binding]
    public class Hooks : BaseClass
    {
        private static ExtentTest featurename, scenario;
        private static ExtentReports htmlreport;

        [BeforeTestRun]
        public static void InitializeReports()
        {
            var reports = new ExtentHtmlReporter(Path.Combine(NUnit.Framework.TestContext.CurrentContext.WorkDirectory + @"\\TestRunReport", "index.html"));
            reports.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            htmlreport = new ExtentReports();
            htmlreport.AttachReporter(reports);

        }

        [AfterTestRun]
        public static void PublishReports()
        {
            htmlreport.Flush();
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            featurename = htmlreport.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);

        }

        [AfterStep]
        public static void AfterStep()
        {
            var step = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            if (ScenarioContext.Current.TestError == null)
            {
                if (step == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (step == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (step == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
            }
            else if (ScenarioContext.Current.TestError != null)
            {
                if (step == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (step == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (step == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
            }
        }

        [BeforeScenario]

        public void BeforeScenario()
        {
            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("Chrome"))
            {
                Driver = DriverFactory.InitiateWebDriver(CommonConstants.DriverSettings.ChromeBrowser);
            }
            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("Edge"))
            {
                Driver = DriverFactory.InitiateWebDriver(CommonConstants.DriverSettings.EdgeBrowser);
            }
            else if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("Headless"))
            {
                Driver = DriverFactory.InitiateWebDriver(CommonConstants.DriverSettings.HeadlessBrowser);
            }
            scenario = featurename.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (NUnit.Framework.TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string pathfile = Path.Combine(NUnit.Framework.TestContext.CurrentContext.WorkDirectory + @"\\Screenshot", "Screenshot.JPG" + "_" +
                DateTime.Now.ToString("(dd_MMMM_hh_mm_ss_ffffff_tt)"));
                var screenshot = Driver.TakeScreenshot();
                screenshot.SaveAsFile(pathfile, ScreenshotImageFormat.Jpeg);
            }
            Driver.Close();
            Driver.Quit();
            Driver.Dispose();
        }
    }
}