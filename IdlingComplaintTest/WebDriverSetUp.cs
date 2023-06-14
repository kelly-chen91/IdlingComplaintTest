using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System.Drawing;

namespace IdlingComplaintTest
{
    internal abstract class WebDriverSetUp
    {
        private IWebDriver iWebDriver;

        protected IWebDriver GetDriver()
        {
            return iWebDriver;
        }

        protected void SetDriver(IWebDriver driver)
        {
            this.iWebDriver = driver;
        }

        [SetUp]
        public virtual void SetUp()
        {
            iWebDriver = CreateDriver("chrome");
            iWebDriver.Manage().Window.Size = new Size(1920, 1200);
            iWebDriver.Navigate().GoToUrl("https://nycidling-dev.azurewebsites.net/login");
        }

        [TearDown]
        public void TearDown()
        {
            iWebDriver.Quit();
        }

        protected IWebDriver CreateDriver(String browserName)
        {
            switch (browserName.ToLowerInvariant())
            {
                case "chrome":
                    var chromeOptions = new ChromeOptions();
                    //chromeOptions.AddArguments(GetBrowserArguments());
                    return new ChromeDriver(chromeOptions);
                case "firefox":
                    var firefoxOptions = new FirefoxOptions();
                    //firefoxOptions.AddArguments(GetBrowserArguments());
                    return new FirefoxDriver(firefoxOptions);
                case "edge":
                    var edgeOptions = new EdgeOptions();
                    //edgeOptions.AddArguments(GetBrowserArguments());
                    return new EdgeDriver(edgeOptions);
                default:
                    throw new Exception("Provided browser is not supported.");
            }
        }

//        public int MaxLengthAttributeValue(IWebElement element)
//        {
//            var attribute = element.GetAttribute("maxlength");
//            Assert.IsNotNull(attribute, "The element does not have a maxlength attribute.");
//            return int.Parse(attribute);
//        }
//
//        public int MinLengthAttributeValue(IWebElement element)
//        {
//            var attribute = element.GetAttribute("minlength");
//            Assert.IsNotNull(attribute, "The element does not have a minlength attribute.");
//            return int.Parse(attribute);
//        }
            
 //       public string GenerateRandomString(int length)
 //       {
 //           const string acceptedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
 //           var random = new Random();
 //           string randomStr = string.Empty;
 //           for(int i = 0; i < length; i++)
 //           {
 //               randomStr += acceptedChars[random.Next(0, acceptedChars.Length)];
 //           }
 //           return randomStr;
 //       }
 //      private string[] GetBrowserArguments()
 //      {
 //          if (ConfigurationProvider.Configuration["browserArguments"] != null)
 //          {
 //              return ConfigurationProvider.Configuration["browserArguments"].Split(",");
 //          }
 //          return Array.Empty<string>(); 
 //      }
    }
}
