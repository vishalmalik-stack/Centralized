﻿
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using TechTalk.SpecFlow;
using UI_Script.Helper;

namespace UI_Script.Hook
{
    [Binding]
    public  class Hooks1 : WebDriver
    {
        public WebDriver _driver;
        //private readonly FeatureContext _featureContext;
        //private readonly ScenarioContext _scenarioContext;
        //private ExtentTest _currentScenarioName;
        //private static ExtentTest featureName;
        //private static ExtentTest step;
        //private static AventStack.ExtentReports.ExtentReports extent;      
        //static string reportPath = System.IO.Directory.GetParent(@"../../..").FullName + Path.DirectorySeparatorChar + "Result"
        //    + Path.DirectorySeparatorChar + "Result_" + DateTime.Now.ToString("ddMMyyyy HHmmss");

        public Hooks1(WebDriver driver, FeatureContext featureContext, ScenarioContext scenarioContext)
        {
            _driver = driver;
            //_featureContext = featureContext;
            //_scenarioContext = scenarioContext;
        }


        //[BeforeTestRun]
        //public static void TestInitilizer()
        //{
        //    var htmlReporter = new ExtentHtmlReporter(reportPath);
        //    htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
        //    extent = new AventStack.ExtentReports.ExtentReports();
        //    extent.AttachReporter(htmlReporter);

        //}

        //[BeforeFeature]
        //public static void BeforeFeature(FeatureContext context)
        //{
        //    featureName = extent.CreateTest(context.FeatureInfo.Title);
        //}

        [BeforeScenario]
        public void BeforeScenario(ScenarioContext context)
        {
            _driver.Driver = new ChromeDriver();
            //_currentScenarioName = featureName.CreateNode(context.ScenarioInfo.Title);
        }

        //[BeforeStep]
        //public void BeforeStep()
        //{
        //    step = _currentScenarioName;
        //}

        //[AfterStep]
        //public void AfterStep(ScenarioContext context)
        //{
        //    if (context.TestError==null)
        //    {
        //        step.Log(Status.Pass, context.StepContext.StepInfo.Text);
        //    }
        //    else if (context.TestError !=null)
        //    {
        //        step.Log(Status.Fail, context.StepContext.StepInfo.Text);
        //    }
        //}

        //[AfterFeature]
        //public static void AfterFeature()
        //{
        //    extent.Flush();
        //}
        [AfterScenario]
        public void AfterScenario()
        {
           _driver.Driver.Quit();
        }
    }
}
