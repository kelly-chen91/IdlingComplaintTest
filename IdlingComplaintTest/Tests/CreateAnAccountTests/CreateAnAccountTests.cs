using IdlingComplaintTest.Pages.CreateAnAccount;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdlingComplaintTest.Tests.CreateAnAccountTests
{
    [Parallelizable(ParallelScope.Children)]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    internal class CreateAnAccountTests : WebDriverSetUp
    {

        // maximum Length in the input box


        // Validation on the Email, phone, address, zip code, password

        //check on the password and the `match password` is match or not

        // Label check: match?

        // Submit verification

        //Cancel button bring back to the home page
        private CreateAnAccountModel createAnAccountModel;

        private const string HEADING = "Profile";
        private const string FIRSTNAME = "First Name";
        private const string LASTNAME = "Last Name";
        private const string EMAIL = "Email";
        private const string PASSWORD = "Password";
        private const string CONFIRMPASSWORD = "Confirm Password";
        private const string SECQUESTION = "Security Question";
        private const string DEFAULTSECQUESTION = "--";
        private const string SECURITYANSWER = "Security Answer";
        private const string ADDRESS1 = "Address1";
        private const string ADDRESS2 = "Address2";
        private const string CITY = "City";
        private const string STATE = "State";
        private const string DEFAULTSTATE = "--";
        private const string ZIPCODE = "Zip Code";
        private const string TELEPHONE = "Telephone";
        [SetUp]
        public void SetUp()
        {
            createAnAccountModel = new CreateAnAccountModel(GetDriver());
            GetDriver().Navigate().GoToUrl("https://nycidling-dev.azurewebsites.net/profile");
        }

        [Test]
        [Category("Label Test")]
        public void HeadingTest()
        {
            Assert.That(GetDriver().FindElement(By.TagName("h4")).Text.Trim(), Is.EqualTo(HEADING));
        }

        [Test]
        [Category("Label Test")]

        //Challenge: Finding the Default Text Option for Security Question dropdown and State options
        public void PlaceholderTest()
        {
            Assert.That(createAnAccountModel.GetFirstName().GetAttribute("placeholder"), Is.EqualTo(FIRSTNAME));
            Assert.That(createAnAccountModel.GetLastName().GetAttribute("placeholder"), Is.EqualTo(LASTNAME));
            Assert.That(createAnAccountModel.GetEmail().GetAttribute("placeholder"), Is.EqualTo(EMAIL));
            Assert.That(createAnAccountModel.GetPassword().GetAttribute("placeholder"), Is.EqualTo(PASSWORD));
            Assert.That(createAnAccountModel.GetConfirmPassword().GetAttribute("placeholder"), Is.EqualTo(CONFIRMPASSWORD));
            Assert.That(createAnAccountModel.GetSecurityQuestion().GetAttribute("placeholder"), Is.EqualTo(SECQUESTION));
            //Assert.That(createAnAccountModel.SelectSecurityQuestionValue(), Is.EqualTo(DEFAULTSECQUESTION));
            Assert.That(createAnAccountModel.GetSecurityAnswer().GetAttribute("placeholder"), Is.EqualTo(SECURITYANSWER));
            Assert.That(createAnAccountModel.GetAddress1().GetAttribute("placeholder"), Is.EqualTo(ADDRESS1));
            Assert.That(createAnAccountModel.GetAddress2().GetAttribute("placeholder"), Is.EqualTo(ADDRESS2));
            Assert.That(createAnAccountModel.GetCity().GetAttribute("placeholder"), Is.EqualTo(CITY));
            Assert.That(createAnAccountModel.GetState().GetAttribute("placeholder"), Is.EqualTo(STATE));
            //Assert.That(createAnAccountModel.GetStateValue(), Is.EqualTo(DEFAULTSTATE));
            Assert.That(createAnAccountModel.GetZipCode().GetAttribute("placeholder"), Is.EqualTo(ZIPCODE));
            Assert.That(createAnAccountModel.GetTelephone().GetAttribute("placeholder"), Is.EqualTo(TELEPHONE));
        }
    }
}
