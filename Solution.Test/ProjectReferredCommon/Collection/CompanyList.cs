using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectReferredCommon.Collection
{
    public class CompanyList : PagesCommon<CompanyList>
    {
        protected override Dictionary<string, By> Locators => new Dictionary<string, By>
        {
            {"dropdown", By.Id("companies") },
            {"signIn",  By.Id("continue") }
        };

        public CompanyList(IWebDriver driver) : base(driver)
        {
        }

        public CompanyList SelectCompany(string name)
        {
            elements["dropdown"].Select(name);
            return this;
        }

        public CompanyList SignIn()
        {
            WaitUtils.WaitLocator(Driver, Locators["dropdown"], 20);
            elements["signIn"].Click();
            return this;
        }

        protected override void WaitForPage()
        {
            WaitUtils.WaitLocator(Driver, Locators["dropdown"], 20);
        }
    }
}
