using IdlingComplaintTest.Pages.CreateAnAccount;
using IdlingComplaintTest.Pages.Login;
using IdlingComplaintTest.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdlingComplaintTest.Tests.CreateAnAccountTests
{
    internal class RegistrationSuccessTest : DriverSetUp.DriverSetUp
    {
        private CreateAnAccountModel createAnAccountModel;

        [SetUp]
        public new void SetUp()
        {
            createAnAccountModel = new CreateAnAccountModel(GetDriver());
            GetDriver().Navigate().GoToUrl("https://nycidling-dev.azurewebsites.net/profile");
            GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        [Test]
        [Category("Successful Registration Test")]
        public void ImplicitWaitSuccessfulRegistrationTest()
        {
            createAnAccountModel.EnterFirstName("Jane");
            createAnAccountModel.EnterLastName("Doe");
            createAnAccountModel.EnterEmail(StringUtilities.GenerateRandomEmail());
            createAnAccountModel.EnterPassword("T3sting@1234");
            createAnAccountModel.EnterConfirmPassword("T3sting@1234");
            createAnAccountModel.SelectSecurityQuestion(1);
            createAnAccountModel.EnterSecurityAnswer("Testing");
            createAnAccountModel.EnterAddress1("59-17 Junction Blvd");
            createAnAccountModel.EnterAddress2("10th Fl");
            createAnAccountModel.EnterCity("Queens");
            createAnAccountModel.SelectState(1);
            createAnAccountModel.EnterZipCode("11373");
            createAnAccountModel.EnterPhone("631-632-9800");
            createAnAccountModel.ScrollToButton();
            createAnAccountModel.ClickSubmitButton();
            var loginButton = GetDriver().FindElement(By.XPath("/html/body/app-root/div/app-login/mat-card/mat-card-content/form/div[3]/button"));
            Assert.IsNotNull(loginButton);
            Thread.Sleep(60000);
        }

        [Test]
        [Category("Cancel Registration Test")]
        public void ImplicitWaitCancelRegistrationTest()
        {
            createAnAccountModel.EnterFirstName("Jane");
            createAnAccountModel.EnterLastName("Doe");
            createAnAccountModel.EnterEmail(StringUtilities.GenerateRandomEmail());
            createAnAccountModel.EnterPassword("T3sting@1234");
            createAnAccountModel.EnterConfirmPassword("T3sting@1234");
            createAnAccountModel.SelectSecurityQuestion(0);
            createAnAccountModel.EnterSecurityAnswer("Testing");
            createAnAccountModel.EnterAddress1("59-17 Junction Blvd");
            createAnAccountModel.EnterAddress2("10th Fl");
            createAnAccountModel.EnterCity("Queens");
            createAnAccountModel.SelectState(1);
            createAnAccountModel.EnterZipCode("11373");
            createAnAccountModel.EnterPhone("631-632-9800");
            createAnAccountModel.ScrollToButton();
            createAnAccountModel.ClickCancelButton();
            var loginButton = GetDriver().FindElement(By.XPath("/html/body/app-root/div/app-login/mat-card/mat-card-content/form/div[3]/button"));
            Assert.IsNotNull(loginButton, "Cancel Button does not load back to the home page.");
            //Thread.Sleep(60000);
        }

        [Test]
        [Category("Cancel Registration Test")]
        public void ClearPageAfterCancelTest()
        {
            Assert.That(createAnAccountModel.GetCancelButton().GetAttribute("type"), Is.EqualTo("reset"));

        }

        [Test]
        public void RandomEmailTest()
        {
            Console.WriteLine(StringUtilities.GenerateRandomEmail());
        }

    }
}
