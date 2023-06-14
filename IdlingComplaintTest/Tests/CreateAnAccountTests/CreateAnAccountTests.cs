using IdlingComplaintTest.Pages.CreateAnAccount;
using IdlingComplaintTest.Utils;
using OpenQA.Selenium;
using System;
using System.Collections;
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
        private const string FIRST_NAME = "First Name";
        private const string LAST_NAME = "Last Name";
        private const string EMAIL = "Email";
        private const string PASSWORD = "Password";
        private const string CONFIRM_PASSWORD = "Confirm Password";
        private const string SEC_QUESTION = "Security Question";
        private const string DEFAULT_SEC_QUESTION = "--";
        private const string SECURITY_ANSWER = "Security Answer";
        private const string ADDRESS_1 = "Address1";
        private const string ADDRESS_2 = "Address2";
        private const string CITY = "City";
        private const string STATE = "State";
        private const string DEFAULT_STATE = "--";
        private const string ZIPCODE = "Zip Code";
        private const string TELEPHONE = "Telephone";
        private const int MAX_NAME_LENGTH = 50;
        private const int MAX_EMAIL_LENGTH = 62;
        private const int MAX_ADDRESS_LENGTH = 95;
        private const int MAX_CITY_LENGTH = 35;
        private const int MAX_PHONE_NUMBER_LENGTH = 13;
        private const int MAX_ZIPCODE_LENGTH = 10;

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
            Assert.That(createAnAccountModel.GetFirstName().GetAttribute("placeholder"), Is.EqualTo(FIRST_NAME));
            Assert.That(createAnAccountModel.GetLastName().GetAttribute("placeholder"), Is.EqualTo(LAST_NAME));
            Assert.That(createAnAccountModel.GetEmail().GetAttribute("placeholder"), Is.EqualTo(EMAIL));
            Assert.That(createAnAccountModel.GetPassword().GetAttribute("placeholder"), Is.EqualTo(PASSWORD));
            Assert.That(createAnAccountModel.GetConfirmPassword().GetAttribute("placeholder"), Is.EqualTo(CONFIRM_PASSWORD));
            Assert.That(createAnAccountModel.GetSecurityQuestion().GetAttribute("placeholder"), Is.EqualTo(SEC_QUESTION));
            //Assert.That(createAnAccountModel.SelectSecurityQuestionValue(), Is.EqualTo(DEFAULT_SEC_QUESTION));
            Assert.That(createAnAccountModel.GetSecurityAnswer().GetAttribute("placeholder"), Is.EqualTo(SECURITY_ANSWER));
            Assert.That(createAnAccountModel.GetAddress1().GetAttribute("placeholder"), Is.EqualTo(ADDRESS_1));
            Assert.That(createAnAccountModel.GetAddress2().GetAttribute("placeholder"), Is.EqualTo(ADDRESS_2));
            Assert.That(createAnAccountModel.GetCity().GetAttribute("placeholder"), Is.EqualTo(CITY));
            Assert.That(createAnAccountModel.GetState().GetAttribute("placeholder"), Is.EqualTo(STATE));
            //Assert.That(createAnAccountModel.GetStateValue(), Is.EqualTo(DEFAULT_STATE));
            Assert.That(createAnAccountModel.GetZipCode().GetAttribute("placeholder"), Is.EqualTo(ZIPCODE));
            Assert.That(createAnAccountModel.GetTelephone().GetAttribute("placeholder"), Is.EqualTo(TELEPHONE));
        }

        [Test]
        public void ValidEmailTest()
        {
            Boolean validEmail = createAnAccountModel.IsValidEmail("kchen@dep");
            Console.WriteLine(validEmail);

        }

        [Test]
        public void ValidPhoneNumberTest()
        {
            Console.WriteLine(createAnAccountModel.IsValidPhoneNumber("917770-0000"));
        }

        [Test]
        public void MaxLengthAttributeTest()
        {
            var maxLengthList = new ArrayList();
            maxLengthList.Add(createAnAccountModel.GetFirstName().MaxLengthAttributeValue()); 
            maxLengthList.Add(createAnAccountModel.GetLastName().MaxLengthAttributeValue());
            maxLengthList.Add(createAnAccountModel.GetEmail().MaxLengthAttributeValue());
            maxLengthList.Add(createAnAccountModel.GetPassword().MaxLengthAttributeValue());
            maxLengthList.Add(createAnAccountModel.GetConfirmPassword().MaxLengthAttributeValue());
            maxLengthList.Add(createAnAccountModel.GetSecurityAnswer().MaxLengthAttributeValue());
            maxLengthList.Add(createAnAccountModel.GetAddress1().MaxLengthAttributeValue());
            maxLengthList.Add(createAnAccountModel.GetAddress2().MaxLengthAttributeValue());
            
           
        }




    }
}
