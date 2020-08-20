using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectReferredCommon.Collection
{
    public class PageElements
    {
        private readonly Dictionary<string, IWebElement> elements = new Dictionary<string, IWebElement>();
        private readonly Dictionary<string, By> locators;
        private readonly IWebDriver driver;

        public PageElements(IWebDriver driver, Dictionary<string, By> locators)
        {
            this.driver = driver;
            this.locators = locators;
        }
    }
    }
