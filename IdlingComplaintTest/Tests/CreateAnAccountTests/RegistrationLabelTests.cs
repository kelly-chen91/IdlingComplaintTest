using IdlingComplaintTest.Pages.CreateAnAccount;
using IdlingComplaintTest.Tests.DriverSetUp;
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
    internal partial class RegistrationLabelTests : DriverSetUp.DriverSetUp
    {
        private CreateAnAccountModel createAnAccountModel;

        [SetUp]
        public new void SetUp()
        {
            createAnAccountModel = new CreateAnAccountModel(GetDriver());
            GetDriver().Navigate().GoToUrl("https://nycidling-dev.azurewebsites.net/profile");
        }
        // maximum Length in the input box

        // Validation on the Email, phone, address, zip code, password

        //check on the password and the `match password` is match or not

        // Label check: match?

        // Submit verification

        //Cancel button bring back to the home page

        /*Checks if the heading is equal to the expected heading*/
        [Test]
        [Category("Text Label Test")]
        public void HeadingTest()
        {
            Assert.That(GetDriver().FindElement(By.TagName("h4")).Text.Trim(), Is.EqualTo(Constants.PROFILE_HEADING));
        }

        [Test]
        [Category("Text Label Test")]

        //Challenge: Finding the Default Text Option for Security Question dropdown and State options
        public void PlaceholderTest()
        {
            Assert.That(createAnAccountModel.GetFirstName().GetAttribute("placeholder"), Is.EqualTo(Constants.FIRST_NAME),
                "First name placeholder is supposed to be \"" + Constants.FIRST_NAME + "\".");
            Assert.That(createAnAccountModel.GetLastName().GetAttribute("placeholder"), Is.EqualTo(Constants.LAST_NAME),
                "Last name placeholder is supposed to be \"" + Constants.LAST_NAME + "\".");
            Assert.That(createAnAccountModel.GetEmail().GetAttribute("placeholder"), Is.EqualTo(Constants.EMAIL),
                "Email placeholder is supposed to be \"" + Constants.EMAIL + "\".");
            Assert.That(createAnAccountModel.GetPassword().GetAttribute("placeholder"), Is.EqualTo(Constants.PASSWORD),
                "Password placeholder is supposed to be \"" + Constants.PASSWORD + "\".");
            Assert.That(createAnAccountModel.GetConfirmPassword().GetAttribute("placeholder"), Is.EqualTo(Constants.CONFIRM_PASSWORD),
                "Confirm Password placeholder is supposed to be \"" + Constants.CONFIRM_PASSWORD + "\".");
            Assert.That(createAnAccountModel.GetSecurityQuestion().GetAttribute("placeholder"), Is.EqualTo(Constants.SEC_QUESTION),
                "Security Question placeholder is supposed to be \"" + Constants.SEC_QUESTION + "\".");
            //Assert.That(createAnAccountModel.SelectSecurityQuestionValue(), Is.EqualTo(DEFAULT_SEC_QUESTION));
            Assert.That(createAnAccountModel.GetSecurityAnswer().GetAttribute("placeholder"), Is.EqualTo(Constants.SECURITY_ANSWER),
                "Security Answer placeholder is supposed to be \"" + Constants.SECURITY_ANSWER + "\".");
            Assert.That(createAnAccountModel.GetAddress1().GetAttribute("placeholder"), Is.EqualTo(Constants.ADDRESS_1),
                "Address1 placeholder is supposed to be \"" + Constants.ADDRESS_1 + "\".");
            Assert.That(createAnAccountModel.GetAddress2().GetAttribute("placeholder"), Is.EqualTo(Constants.ADDRESS_2),
                "Address2 placeholder is supposed to be \"" + Constants.ADDRESS_2 + "\".");
            Assert.That(createAnAccountModel.GetCity().GetAttribute("placeholder"), Is.EqualTo(Constants.CITY),
                "City placeholder is supposed to be \"" + Constants.CITY + "\".");
            Assert.That(createAnAccountModel.GetState().GetAttribute("placeholder"), Is.EqualTo(Constants.STATE),
                "State placeholder is supposed to be \"" + Constants.STATE + "\".");
            //Assert.That(createAnAccountModel.GetStateValue(), Is.EqualTo(DEFAULT_STATE));
            Assert.That(createAnAccountModel.GetZipCode().GetAttribute("placeholder"), Is.EqualTo(Constants.ZIPCODE),
                "Zipcode placeholder is supposed to be \"" + Constants.ZIPCODE + "\".");
            Assert.That(createAnAccountModel.GetTelephone().GetAttribute("placeholder"), Is.EqualTo(Constants.TELEPHONE),
                "Telephone placeholder is supposed to be \"" + Constants.TELEPHONE + "\".");
        }

        [Test]
        [Category("Button Label Test")]
        public void SubmitButtonLabelTest()
        {
            string submitButtonText = createAnAccountModel.ExtractTextFromXPath("/html/body/app-root/div/profile/form/div/button[1]/span/text()");
            Assert.That(submitButtonText.Trim(), Is.EqualTo("Submit"));
        }

        [Test]
        [Category("Button Label Test")]
        public void CancelButtonLabelTest()
        {
            string cancelButtonText = createAnAccountModel.ExtractTextFromXPath("/html/body/app-root/div/profile/form/div/button[2]/span/text()");
            Assert.That(cancelButtonText.Trim(), Is.EqualTo("Cancel"));
        }

        [Test]
        [Category("Text Label Test")]
        public void PasswordPolicyLabelTest()
        {
            string passwordPolicyText1 = createAnAccountModel.ExtractTextFromXPath("/html/body/app-root/div/profile/form/div/div/label/text()[1]");
            string passwordPolicyText2 = createAnAccountModel.ExtractTextFromXPath("/html/body/app-root/div/profile/form/div/div/label/text()[2]");
            //Assert.That(passwordPolicyText1, Is.EqualTo());
        }
    }
}
