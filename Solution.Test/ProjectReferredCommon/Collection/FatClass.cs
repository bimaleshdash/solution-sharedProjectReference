using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;



namespace ProjectReferredCommon.Collection
{
    public class FatClass
    {
        public static T ReadConfig<T>(string filename) where T : IBrowserConfig
        {
            var currentDir = Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath);
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(Path.Combine(currentDir, filename)));
        }
        public static IWebDriver CreateChromeDriver(IBrowserConfig config)
        {
            var driverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var driverService = ChromeDriverService.CreateDefaultService(driverPath);
            var opt = new ChromeOptions();
            opt.AddArgument("--ignore-certificate-errors");
            if (config.Headless && !config.Debug)
            {
                opt.AddArgument("--window-size=1280,2048");
                opt.AcceptInsecureCertificates = true;
                opt.AddArgument("--headless");
            }
            opt.AddUserProfilePreference("download.default_directory", config.DownloadFolder);

            var driver = new ChromeDriver(driverService, opt, TimeSpan.FromMinutes(5));
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(5);

            return driver;
        }
    }
}
