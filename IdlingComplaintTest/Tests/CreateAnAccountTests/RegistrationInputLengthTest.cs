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

    internal class RegistrationInputLengthTest : DriverSetUp.DriverSetUp
    {
        private CreateAnAccountModel createAnAccountModel;

        [SetUp]
        public new void SetUp()
        {
            createAnAccountModel = new CreateAnAccountModel(GetDriver());
            GetDriver().Navigate().GoToUrl("https://nycidling-dev.azurewebsites.net/profile");
        }
        [Test]
        public void NameMaxLengthAttributeTest()
        {
            int maxFirstNameLength = createAnAccountModel.GetFirstName().MaxLengthAttributeValue();
            int maxLastNameLength = createAnAccountModel.GetLastName().MaxLengthAttributeValue();

            Assert.That(maxFirstNameLength, Is.EqualTo(Constants.MAX_NAME_LENGTH), "The maxlength attribute for name is supposed to be: " + Constants.MAX_NAME_LENGTH);
            Assert.That(maxLastNameLength, Is.EqualTo(Constants.MAX_NAME_LENGTH), "The maxlength attribute for name is supposed to be: " + Constants.MAX_NAME_LENGTH); //group with above
        }

        [Test]
        [Category("Maxlength Attribute Test")]
        public void EmailMaxLengthAttributeTest()
        {
            int maxEmailLength = createAnAccountModel.GetEmail().MaxLengthAttributeValue();
            Assert.That(maxEmailLength, Is.EqualTo(Constants.MAX_EMAIL_LENGTH), "The maxlength attribute for email is supposed to be: " + Constants.MAX_EMAIL_LENGTH);
        }

        [Test]
        [Category("Maxlength Attribute Test")]
        public void PasswordMaxLengthAttributeTest()
        {
            int maxPasswordLength = createAnAccountModel.GetPassword().MaxLengthAttributeValue();
            int maxConfirmPasswordLength = createAnAccountModel.GetConfirmPassword().MaxLengthAttributeValue();
            Assert.That(maxPasswordLength, Is.EqualTo(Constants.MAX_PASSWORD_LENGTH), "The maxlength attribute for password is supposed to be: " + Constants.MAX_PASSWORD_LENGTH);
            Assert.That(maxConfirmPasswordLength, Is.EqualTo(Constants.MAX_PASSWORD_LENGTH), "The maxlength attribute for email is supposed to be: " + Constants.MAX_PASSWORD_LENGTH);//group with above

        }

        [Test]
        [Category("Maxlength Attribute Test")]
        public void SecurityAnswerMaxLengthAttributeTest()
        {
            int maxSecurityAnsLength = createAnAccountModel.GetSecurityAnswer().MaxLengthAttributeValue();
            Assert.That(maxSecurityAnsLength, Is.EqualTo(Constants.MAX_SECURITY_ANSWER_LENGTH), "The maxlength attribute for email is supposed to be: " + Constants.MAX_SECURITY_ANSWER_LENGTH);

        }

        [Test]
        [Category("Maxlength Attribute Test")]
        public void AddressMaxLengthAttributeTest()
        {
            int maxAddress1Length = createAnAccountModel.GetAddress1().MaxLengthAttributeValue();
            int maxAddress2Length = createAnAccountModel.GetAddress2().MaxLengthAttributeValue();
            Assert.That(maxAddress1Length, Is.EqualTo(Constants.MAX_ADDRESS_LENGTH), "The maxlength attribute for email is supposed to be: " + Constants.MAX_ADDRESS_LENGTH);
            Assert.That(maxAddress2Length, Is.EqualTo(Constants.MAX_ADDRESS_LENGTH), "The maxlength attribute for email is supposed to be: " + Constants.MAX_ADDRESS_LENGTH);
        }

        [Test]
        [Category("Maxlength Attribute Test")]
        public void CityMaxLengthAttributeTest()
        {
            int maxCityLength = createAnAccountModel.GetCity().MaxLengthAttributeValue();
            Assert.That(maxCityLength, Is.EqualTo(Constants.MAX_CITY_LENGTH), "The maxlength attribute for email is supposed to be: " + Constants.MAX_CITY_LENGTH);

        }

        [Test]
        [Category("Maxlength Attribute Test")]
        public void ZipCodeMaxLengthAttributeTest()
        {
            int maxZipCodeLength = createAnAccountModel.GetZipCode().MaxLengthAttributeValue();
            Assert.That(maxZipCodeLength, Is.EqualTo(Constants.MAX_ZIPCODE_LENGTH), "The maxlength attribute for email is supposed to be: " + Constants.MAX_ZIPCODE_LENGTH);

        }

        [Test]
        [Category("Maxlength Attribute Test")]
        public void TelephoneMaxLengthAttributeTest()
        {
            int maxTelephoneLength = createAnAccountModel.GetTelephone().MaxLengthAttributeValue();
            Assert.That(maxTelephoneLength, Is.EqualTo(Constants.MAX_PHONE_NUMBER_LENGTH), "The maxlength attribute for email is supposed to be: " + Constants.MAX_PHONE_NUMBER_LENGTH);

        }

    }
}
