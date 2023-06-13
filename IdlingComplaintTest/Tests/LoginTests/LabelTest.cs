using IdlingComplaintTest.Pages.Login;
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
        private const string EMAIL = "Email";
        private const string PASSWORD = "Password";
        private const string HEADING = "NYC Idling Complaint";
        private const string LOGIN = "Login";
        private const string FORGOT_PASS = "Forgot Password";
        private const string NOT_REGISTERED = "Not registered?";
        private const string CREATE_ACCOUNT = "Create an account";
        [SetUp]
        public new void SetUp()
        {
            loginModel = new LoginModel(GetDriver());
        }

        [Test]
        //Tests whether the input name matches with "Email" 
        [Category("Test with Input Value")]
        public void EmailTest()
        {
            var placeholder = GetDriver().FindElement(By.Name("email")).GetAttribute("placeholder");
            Assert.That(placeholder, Is.EqualTo(EMAIL));
        }

        [Test]
        //Tests whether the input name matches with "Password" 
        [Category("Test with Input Value")]
        public void PasswordTest()
        {
            var placeholder = GetDriver().FindElement(By.Name("password")).GetAttribute("placeholder");
            Assert.That(placeholder, Is.EqualTo(PASSWORD));
        }

        [Test]
        //Tests whether the heading matches with "NYC Idling Complaint"
        [Category("Test with Text Label")]
        public void HeadingTest()
        {
            Assert.That(GetDriver().FindElement(By.TagName("h3")).Text, Is.EqualTo(HEADING));
        }

        [Test]
        [Category("Test with Text Label")]
        public void LoginLabelTest()
        {
            Assert.That(GetDriver().FindElement(By.TagName("h4")).Text, Is.EqualTo(LOGIN));
        }

        [Test]
        [Category("Test with Text Label")]
        public void LoginButtonLabelTest()
        {
            Assert.That(GetDriver().FindElement(By.TagName("button")).Text, Is.EqualTo(LOGIN));
        }

        [Test]
        [Category("Test with Text Label")]
        public void ForgetPasswordTextTest()
        {
            Assert.That(GetDriver().FindElement(By.PartialLinkText("Forgot")).Text, Is.EqualTo(FORGOT_PASS));
        }

        [Test]
        [Category("Test with Text Label")]
        public void CreateAccountTextTest()
        {
            Assert.That(GetDriver().FindElement(By.PartialLinkText("Create")).Text, Is.EqualTo(CREATE_ACCOUNT));
        }

        [Test]
        [Category("Test with Text Label")]
        public void NotRegisteredTextTest()
        {
            IWebElement forgotPWUrl = GetDriver().FindElement(By.PartialLinkText("Forgot"));
            //            Assert.That(GetDriver().FindElement(RelativeBy.WithLocator(By.TagName("p")
            //                                                                         .Below(forgotPWUrl))));
        }

    }
}
