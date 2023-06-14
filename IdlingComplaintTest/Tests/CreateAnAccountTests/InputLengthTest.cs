using IdlingComplaintTest.Pages.CreateAnAccount;
using IdlingComplaintTest.Tests.DriverSetUp;
using IdlingComplaintTest.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdlingComplaintTest.Tests.CreateAnAccountTests
{

    internal class InputLengthTest : DriverSetUp.DriverSetUp
    {
        private CreateAnAccountModel createAnAccountModel;

        [SetUp]
        public new void SetUp()
        {
            createAnAccountModel = new CreateAnAccountModel(GetDriver());
            GetDriver().Navigate().GoToUrl("https://nycidling-dev.azurewebsites.net/profile");
        }
        [Test]
        public void MaxLengthAttributeTest()
        {
            int maxFirstNameLength = createAnAccountModel.GetFirstName().MaxLengthAttributeValue();
            int maxLastNameLength = createAnAccountModel.GetLastName().MaxLengthAttributeValue();
            int maxEmailLength = createAnAccountModel.GetEmail().MaxLengthAttributeValue();
            int maxPasswordLength = createAnAccountModel.GetPassword().MaxLengthAttributeValue();
            int maxConfirmPasswordLength = createAnAccountModel.GetConfirmPassword().MaxLengthAttributeValue();
            int maxSecurityAnsLength = createAnAccountModel.GetSecurityAnswer().MaxLengthAttributeValue();
            int maxAddress1Length = createAnAccountModel.GetAddress1().MaxLengthAttributeValue();
            int maxAddress2Length = createAnAccountModel.GetAddress2().MaxLengthAttributeValue();
            int maxCityLength = createAnAccountModel.GetCity().MaxLengthAttributeValue();
            int maxZipCodeLength = createAnAccountModel.GetZipCode().MaxLengthAttributeValue();
            int maxTelephoneLength = createAnAccountModel.GetTelephone().MaxLengthAttributeValue();

            Assert.That(maxFirstNameLength, Is.EqualTo(Constants.MAX_NAME_LENGTH), "The maxlength attribute for name is supposed to be: " + Constants.MAX_NAME_LENGTH);
            Assert.That(maxLastNameLength, Is.EqualTo(Constants.MAX_NAME_LENGTH), "The maxlength attribute for name is supposed to be: " + Constants.MAX_NAME_LENGTH);
            Assert.That(maxEmailLength, Is.EqualTo(Constants.MAX_EMAIL_LENGTH), "The maxlength attribute for email is supposed to be: " + Constants.MAX_EMAIL_LENGTH);
            Assert.That(maxPasswordLength, Is.EqualTo(Constants.MAX_PASSWORD_LENGTH), "The maxlength attribute for password is supposed to be: " + Constants.MAX_PASSWORD_LENGTH);
            Assert.That(maxConfirmPasswordLength, Is.EqualTo(Constants.MAX_PASSWORD_LENGTH), "The maxlength attribute for email is supposed to be: " + Constants.MAX_PASSWORD_LENGTH);
            Assert.That(maxSecurityAnsLength, Is.EqualTo(Constants.MAX_SECURITY_ANSWER_LENGTH), "The maxlength attribute for email is supposed to be: " + Constants.MAX_SECURITY_ANSWER_LENGTH);
            Assert.That(maxAddress1Length, Is.EqualTo(Constants.MAX_ADDRESS_LENGTH), "The maxlength attribute for email is supposed to be: " + Constants.MAX_ADDRESS_LENGTH);
            Assert.That(maxAddress2Length, Is.EqualTo(Constants.MAX_ADDRESS_LENGTH), "The maxlength attribute for email is supposed to be: " + Constants.MAX_ADDRESS_LENGTH);
            Assert.That(maxCityLength, Is.EqualTo(Constants.MAX_CITY_LENGTH), "The maxlength attribute for email is supposed to be: " + Constants.MAX_CITY_LENGTH);
            Assert.That(maxZipCodeLength, Is.EqualTo(Constants.MAX_ZIPCODE_LENGTH), "The maxlength attribute for email is supposed to be: " + Constants.MAX_ZIPCODE_LENGTH);
            Assert.That(maxTelephoneLength, Is.EqualTo(Constants.MAX_PHONE_NUMBER_LENGTH), "The maxlength attribute for email is supposed to be: " + Constants.MAX_PHONE_NUMBER_LENGTH);
        }
    }
}
