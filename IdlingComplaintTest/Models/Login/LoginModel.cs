using OpenQA.Selenium;

namespace IdlingComplaintTest.Pages.Login
{
    internal class LoginModel : PageSetup
    {
        public LoginModel(IWebDriver driver) : base(driver)
        {
        }

        //Variable for the Email input text box
        private IWebElement Email => driver.FindElement(By.Name("email"));

        //Variable for the password input text box
        private IWebElement Password => driver.FindElement(By.Name("password"));
        // private IWebElement TotalPrice => Get.FindElement(By.CssSelector("tfoot tr th:nth-child(3)"));

        //  private List<IWebElement> Workshops => Get.FindElements(RelativeBy
        //           .WithLocator(By.CssSelector("input[type='checkbox']"))
        //           .Below(Email))
        //           .ToList();

        //  private IWebElement Notes => Get.FindElement(RelativeBy
        //          .WithLocator(By.TagName("textarea"))
        //          .Below(Email));
        //
        private IWebElement LoginButton => driver.FindElement(By.ClassName("mat-button-wrapper"));


        //private List<IWebElement> OrderTableItems => Get.FindElements(By.CssSelector(".order-summary tbody tr")).ToList();

        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
        }

        public string GetEmailValue()
        {
            return Email.GetAttribute("value");
        }

        //Add getter and setter for password
        public void EnterPassword(string password)
        {
            Password.SendKeys(password);
        }

        public string GetPasswordValue()
        {
            return Password.GetAttribute("value");
        }

        public void ClickLoginButton()
        {
            LoginButton.Click();
        }

        public void ScrollToTheLoginButton()
        {
            ScrollToElement(LoginButton);
        }

        //   public LoginStatusPage ClickLoginButton()
        //   {
        //       LoginButton.Click();
        //       return new LoginStatusPage(driver);
        //   }

        //   public int GetOrderTicketsCount()
        //   {
        //       return OrderTableItems.Count;
        //   }

        //   public void ScrollToTheTicketRemoveButton(int index)
        //   {
        //       ScrollToElement(OrderTableItems[0]);
        //   }

        //   public void ClickOnTheTicketRemoveButton(int index)
        //   {
        //       OrderTableItems[index].FindElement(By.TagName("button")).Click();
        //   }
    }
}
