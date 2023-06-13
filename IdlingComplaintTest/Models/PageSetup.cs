﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace IdlingComplaintTest.Pages
{
    internal class PageSetup
    {
        protected readonly IWebDriver driver;

        protected PageSetup(IWebDriver driver)
        {
            this.driver = driver;
        }

        protected void ScrollToElement(IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            Thread.Sleep(500);
        }
    }
}
