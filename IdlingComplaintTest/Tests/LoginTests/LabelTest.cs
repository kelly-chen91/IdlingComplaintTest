using IdlingComplaintTest.Pages.Login;
using IdlingComplaintTest.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *This is the label test class for testing the labels in the login page
 */

namespace IdlingComplaintTest.Tests.LoginTests
{
    [Parallelizable(ParallelScope.Children)]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    internal class LabelTest : WebDriverSetUp
    {
        private LoginModel loginModel;
        //private const string EMAIL = "Email";
        //private const string PASSWORD = "Password";
        //private const string HEADING = "NYC Idling Complaint";
        //private const string LOGIN = "Login";
        //private const string FORGOT_PASS = "Forgot Password";
        //private const string NOT_REGISTERED = "Not registered?";
        //private const string CREATE_ACCOUNT = "Create an account";
        [SetUp]
        public new void SetUp()
        {
            loginModel = new LoginModel(GetDriver());
        }

        [Test]
        //Tests whether the input name matches with "Email" 
        [Category("Input Value Test")]
        public void EmailTest()
        {
            var placeholder = GetDriver().FindElement(By.Name("email")).GetAttribute("placeholder");
            Assert.That(placeholder, Is.EqualTo(Labels.EMAIL));
        }

        [Test]
        //Tests whether the input name matches with "Password" 
        [Category("Input Value Test")]
        public void PasswordTest()
        {
            var placeholder = GetDriver().FindElement(By.Name("password")).GetAttribute("placeholder");
            Assert.That(placeholder, Is.EqualTo(Labels.PASSWORD));
        }

        [Test]
        //Tests whether the heading matches with "NYC Idling Complaint"
        [Category("Text Label Test")]
        public void HeadingTest()
        {
            Assert.That(GetDriver().FindElement(By.TagName("h3")).Text, Is.EqualTo(Labels.LOGIN_HEADING), "Heading does not match \"" + Labels.LOGIN_HEADING + "\"");
        }

        [Test]
        [Category("Text Label Test")]
        public void LoginLabelTest()
        {
            string text = loginModel.ExtractTextFromXPath("/html/body/app-root/div/app-login/mat-card/mat-card-header/div/mat-card-title/h4/text()");
            Assert.That(text, Is.EqualTo(Labels.LOGIN), "Login label does not match \"" + Labels.LOGIN + "\"");
        }

        [Test]
        [Category("Button Label Test")]
        public void LoginButtonLabelTest()
        {
            string loginButtonText = loginModel.ExtractTextFromXPath("/html/body/app-root/div/app-login/mat-card/mat-card-content/form/div[3]/button/span/text()");
            Assert.That(loginButtonText, Is.EqualTo(Labels.LOGIN), "Login button does not match \"" + Labels.LOGIN + "\"");
        }

        [Test]
        [Category("Text Label Test")]
        public void ForgetPasswordTextTest()
        {
            Assert.That(GetDriver().FindElement(By.PartialLinkText("Forgot")).Text, Is.EqualTo(Labels.FORGOT_PASS), "Forget password does not match \"" + Labels.FORGOT_PASS + "\"");
        }

        [Test]
        [Category("Text Label Test")]
        public void CreateAccountTextTest()
        {
            Assert.That(GetDriver().FindElement(By.PartialLinkText("Create")).Text, Is.EqualTo(Labels.CREATE_ACCOUNT),  "Create account does not match \"" + Labels.CREATE_ACCOUNT + "\"");
        }

        [Test]
        [Category("Text Label Test")]
        public void NotRegisteredTextTest()
        {
            string notRegisteredText = loginModel.ExtractTextFromXPath("/html/body/app-root/div/app-login/mat-card/mat-card-content/form/div[4]/p/text()");
            Assert.That(notRegisteredText, Is.EqualTo(Labels.NOT_REGISTERED), "Not registered text does not match \"" + Labels.NOT_REGISTERED + "\"");
            //IWebElement forgotPWUrl = GetDriver().FindElement(By.PartialLinkText("Forgot"));
            //            Assert.That(GetDriver().FindElement(RelativeBy.WithLocator(By.TagName("p")
            //                                                                         .Below(forgotPWUrl))));
        }

        [Test]
        [Category("Link Verification Test")]
        public void VerifyForgotPasswordLinkTest()
        {
            string forgotPassLink = GetDriver().FindElement(By.PartialLinkText("Forgot")).GetAttribute("href");
            Assert.That(forgotPassLink, Is.EqualTo("https://nycidling-dev.azurewebsites.net/password-reset"), "Forgot Password Link is not routing to \"/password-reset\" link.");
        }

        [Test]
        [Category("Link Verification Test")]
        public void VerifyCreateAccountLinkTest()
        {
            string createAccountLink = GetDriver().FindElement(By.PartialLinkText("Create")).GetAttribute("href");
            Assert.That(createAccountLink, Is.EqualTo("https://nycidling-dev.azurewebsites.net/profile"), "Forgot Password Link is not routing to \"/profile\" link.");
        }
    }
}
