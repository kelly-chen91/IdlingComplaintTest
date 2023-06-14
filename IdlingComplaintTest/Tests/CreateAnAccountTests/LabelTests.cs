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
    internal class LabelTests : CreateAnAccountTestSetUp
    {

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
            Assert.That(GetDriver().FindElement(By.TagName("h4")).Text.Trim(), Is.EqualTo(Labels.PROFILE_HEADING));
        }

        [Test]
        [Category("Text Label Test")]

        //Challenge: Finding the Default Text Option for Security Question dropdown and State options
        public void PlaceholderTest()
        {
            Assert.That(GetCreateAnAccountModel().GetFirstName().GetAttribute("placeholder"), Is.EqualTo(Labels.FIRST_NAME),
                "First name placeholder is supposed to be \"" + Labels.FIRST_NAME + "\".");
            Assert.That(GetCreateAnAccountModel().GetLastName().GetAttribute("placeholder"), Is.EqualTo(Labels.LAST_NAME),
                "Last name placeholder is supposed to be \"" + Labels.LAST_NAME + "\".");
            Assert.That(GetCreateAnAccountModel().GetEmail().GetAttribute("placeholder"), Is.EqualTo(Labels.EMAIL),
                "Email placeholder is supposed to be \"" + Labels.EMAIL + "\".");
            Assert.That(GetCreateAnAccountModel().GetPassword().GetAttribute("placeholder"), Is.EqualTo(Labels.PASSWORD),
                "Password placeholder is supposed to be \"" + Labels.PASSWORD + "\".");
            Assert.That(GetCreateAnAccountModel().GetConfirmPassword().GetAttribute("placeholder"), Is.EqualTo(Labels.CONFIRM_PASSWORD),
                "Confirm Password placeholder is supposed to be \"" + Labels.CONFIRM_PASSWORD + "\".");
            Assert.That(GetCreateAnAccountModel().GetSecurityQuestion().GetAttribute("placeholder"), Is.EqualTo(Labels.SEC_QUESTION),
                "Security Question placeholder is supposed to be \"" + Labels.SEC_QUESTION + "\".");
            //Assert.That(GetCreateAnAccountModel().SelectSecurityQuestionValue(), Is.EqualTo(Labels.DEFAULT_SEC_QUESTION));
            Assert.That(GetCreateAnAccountModel().GetSecurityAnswer().GetAttribute("placeholder"), Is.EqualTo(Labels.SECURITY_ANSWER),
                "Security Answer placeholder is supposed to be \"" + Labels.SECURITY_ANSWER + "\".");
            Assert.That(GetCreateAnAccountModel().GetAddress1().GetAttribute("placeholder"), Is.EqualTo(Labels.ADDRESS_1),
                "Address1 placeholder is supposed to be \"" + Labels.ADDRESS_1 + "\".");
            Assert.That(GetCreateAnAccountModel().GetAddress2().GetAttribute("placeholder"), Is.EqualTo(Labels.ADDRESS_2),
                "Address2 placeholder is supposed to be \"" + Labels.ADDRESS_2 + "\".");
            Assert.That(GetCreateAnAccountModel().GetCity().GetAttribute("placeholder"), Is.EqualTo(Labels.CITY),
                "City placeholder is supposed to be \"" + Labels.CITY + "\".");
            Assert.That(GetCreateAnAccountModel().GetState().GetAttribute("placeholder"), Is.EqualTo(Labels.STATE),
                "State placeholder is supposed to be \"" + Labels.STATE + "\".");
            //Assert.That(GetCreateAnAccountModel().GetStateValue(), Is.EqualTo(Labels.DEFAULT_STATE));
            Assert.That(GetCreateAnAccountModel().GetZipCode().GetAttribute("placeholder"), Is.EqualTo(Labels.ZIPCODE),
                "Zipcode placeholder is supposed to be \"" + Labels.ZIPCODE + "\".");
            Assert.That(GetCreateAnAccountModel().GetTelephone().GetAttribute("placeholder"), Is.EqualTo(Labels.TELEPHONE),
                "Telephone placeholder is supposed to be \"" + Labels.TELEPHONE + "\".");
        }

        [Test]
        public void MaxLengthAttributeTest()
        {
            int maxFirstNameLength = GetCreateAnAccountModel().GetFirstName().MaxLengthAttributeValue();
            int maxLastNameLength = GetCreateAnAccountModel().GetLastName().MaxLengthAttributeValue();
            int maxEmailLength = GetCreateAnAccountModel().GetEmail().MaxLengthAttributeValue();
            int maxPasswordLength = GetCreateAnAccountModel().GetPassword().MaxLengthAttributeValue();
            int maxConfirmPasswordLength = GetCreateAnAccountModel().GetConfirmPassword().MaxLengthAttributeValue();
            int maxSecurityAnsLength = GetCreateAnAccountModel().GetSecurityAnswer().MaxLengthAttributeValue();
            int maxAddress1Length = GetCreateAnAccountModel().GetAddress1().MaxLengthAttributeValue();
            int maxAddress2Length = GetCreateAnAccountModel().GetAddress2().MaxLengthAttributeValue();
            int maxCityLength = GetCreateAnAccountModel().GetCity().MaxLengthAttributeValue();
            int maxZipCodeLength = GetCreateAnAccountModel().GetZipCode().MaxLengthAttributeValue();
            int maxTelephoneLength = GetCreateAnAccountModel().GetTelephone().MaxLengthAttributeValue();

            Assert.That(maxFirstNameLength, Is.EqualTo(Labels.MAX_NAME_LENGTH), "The maxlength attribute for name is supposed to be: " + Labels.MAX_NAME_LENGTH);
            Assert.That(maxLastNameLength, Is.EqualTo(Labels.MAX_NAME_LENGTH), "The maxlength attribute for name is supposed to be: " + Labels.MAX_NAME_LENGTH);
            Assert.That(maxEmailLength, Is.EqualTo(Labels.MAX_EMAIL_LENGTH), "The maxlength attribute for email is supposed to be: " + Labels.MAX_EMAIL_LENGTH);
            Assert.That(maxPasswordLength, Is.EqualTo(Labels.MAX_PASSWORD_LENGTH), "The maxlength attribute for password is supposed to be: " + Labels.MAX_PASSWORD_LENGTH);
            Assert.That(maxConfirmPasswordLength, Is.EqualTo(Labels.MAX_PASSWORD_LENGTH), "The maxlength attribute for email is supposed to be: " + Labels.MAX_PASSWORD_LENGTH);
            Assert.That(maxSecurityAnsLength, Is.EqualTo(Labels.MAX_SECURITY_ANSWER_LENGTH), "The maxlength attribute for email is supposed to be: " + Labels.MAX_SECURITY_ANSWER_LENGTH);
            Assert.That(maxAddress1Length, Is.EqualTo(Labels.MAX_ADDRESS_LENGTH), "The maxlength attribute for email is supposed to be: " + Labels.MAX_ADDRESS_LENGTH);
            Assert.That(maxAddress2Length, Is.EqualTo(Labels.MAX_ADDRESS_LENGTH), "The maxlength attribute for email is supposed to be: " + Labels.MAX_ADDRESS_LENGTH);
            Assert.That(maxCityLength, Is.EqualTo(Labels.MAX_CITY_LENGTH), "The maxlength attribute for email is supposed to be: " + Labels.MAX_CITY_LENGTH);
            Assert.That(maxZipCodeLength, Is.EqualTo(Labels.MAX_ZIPCODE_LENGTH), "The maxlength attribute for email is supposed to be: " + Labels.MAX_ZIPCODE_LENGTH);
            Assert.That(maxTelephoneLength, Is.EqualTo(Labels.MAX_PHONE_NUMBER_LENGTH), "The maxlength attribute for email is supposed to be: " + Labels.MAX_PHONE_NUMBER_LENGTH);
        }

        [Test]
        [Category("Button Label Test")]
        public void SubmitButtonLabelTest()
        {
            string submitButtonText = GetCreateAnAccountModel().ExtractTextFromXPath("/html/body/app-root/div/profile/form/div/button[1]/span/text()");
            Assert.That(submitButtonText.Trim(), Is.EqualTo("Submit"));
        }

        [Test]
        [Category("Button Label Test")]
        public void CancelButtonLabelTest()
        {
            string cancelButtonText = GetCreateAnAccountModel().ExtractTextFromXPath("/html/body/app-root/div/profile/form/div/button[2]/span/text()");
            Assert.That(cancelButtonText.Trim(), Is.EqualTo("Cancel"));
        }

        [Test]
        [Category("Text Label Test")]
        public void PasswordPolicyLabelTest()
        {
            string passwordPolicyText1 = GetCreateAnAccountModel().ExtractTextFromXPath("/html/body/app-root/div/profile/form/div/div/label/text()[1]");
            string passwordPolicyText2 = GetCreateAnAccountModel().ExtractTextFromXPath("/html/body/app-root/div/profile/form/div/div/label/text()[2]");
            Assert.That(passwordPolicyText1, Is.EqualTo());
        }
    }
}
