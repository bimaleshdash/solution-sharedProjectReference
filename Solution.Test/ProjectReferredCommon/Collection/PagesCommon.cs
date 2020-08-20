using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectReferredCommon.Collection
{
    public abstract class PagesCommon<T> where T : PagesCommon<T>
    {
        protected readonly IWebDriver Driver;

        protected PageElements elements;

        protected abstract Dictionary<string, By> Locators { get; }

        protected PagesCommon(IWebDriver driver)
        {
            Driver = driver;
            elements = new PageElements(driver, Locators);
            WaitForPage();
        }

        protected virtual void WaitForPage() { }

        public T RefreshPage()
        {
            Driver.Navigate().Refresh();
            return (T)this;
        }

    }
}
