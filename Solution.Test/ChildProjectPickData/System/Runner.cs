using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using ProjectReferredCommon.Collection;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace ChildProjectPickData.System
{
    [Binding]
    static class Runner
    {
        public static IWebDriver Driver;
        public static LocalBrowserConfig Config = FatClass.ReadConfig<LocalBrowserConfig>("testconfig.json");
        [BeforeScenario]
        public static void BeforeScenario()
        {
            Driver = FatClass.CreateChromeDriver(Config); 
        }

        [AfterScenario(Order = 10)]
        public static void TakeScreenshot()
        {
            Driver.TakeScreenshot();
        }
    }
}
