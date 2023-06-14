using OpenQA.Selenium;
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
            Thread.Sleep(5000);
        }

        public string ExtractTextFromXPath(string path)
        {
            string script = "var element = document.evaluate(\""
            + path
            + "\", document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue;"
            + "if (element) { return element.nodeValue.trim(); } else return ''; ";
            return (string)((IJavaScriptExecutor)driver).ExecuteScript(script);
        }
    }
}
