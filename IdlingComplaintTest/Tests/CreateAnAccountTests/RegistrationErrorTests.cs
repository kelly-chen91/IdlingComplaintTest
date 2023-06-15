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
    [Parallelizable(ParallelScope.Children)]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    internal class RegistrationErrorTests : DriverSetUp.DriverSetUp
    {
        private CreateAnAccountModel createAnAccountModel;

        [SetUp]
        public new void SetUp()
        {
            createAnAccountModel = new CreateAnAccountModel(GetDriver());
            GetDriver().Navigate().GoToUrl("https://nycidling-dev.azurewebsites.net/profile");
            createAnAccountModel.ClickSubmitButton();
        }

        public void ValidEmailTest()
        {
            //Boolean validEmail = createAnAccountModel.IsValidEmail("kchen@dep");
            //Console.WriteLine(validEmail);
            /* The program does not test for valid email addresses */

        }

        public void ValidZipCodeTest()
        {
            /* The program does not test for valid zip code upon entry */
        }

        public void ValidPhoneNumberTest()
        {
            //Console.WriteLine(createAnAccountModel.IsValidPhoneNumber("917770-0000"));
            /* The program does not test for valid phone numbers */
        }

        /*Tests for error when first name field is empty*/
        [Test]
        [Category("Required Empty Fields Label Test")]
        public void RequiredFirstNameTest()
        {
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[1]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(Constants.REQUIRED));
        }

        /*Tests for error when last name field is empty*/
        [Test]
        [Category("Required Empty Fields Label Test")]
        public void RequiredLastNameTest()
        {
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[2]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(Constants.REQUIRED));
        }

        /*Tests for error when email field is empty*/
        [Test]
        [Category("Required Empty Fields Label Test")]
        public void RequiredEmailTest()
        {
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[3]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(Constants.REQUIRED));
        }

        /*Tests for error when password field is empty*/
        [Test]
        [Category("Required Empty Fields Label Test")]
        public void RequiredPasswordTest()
        {
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[4]/div[1]/div[1]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(Constants.PASSWORD_REQUIRED));
        }

        /*Tests for error when confirm password field is empty*/
        [Test]
        [Category("Required Empty Fields Label Test")]
        public void RequiredConfirmPasswordTest()
        {
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[4]/div[1]/div[2]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(Constants.CONFIRM_PASSWORD_REQUIRED));
        }

        /*Tests for error when security question field is empty*/
        [Test]
        [Category("Required Empty Fields Label Test")]
        public void RequiredSecurityQuestionTest()
        {
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[4]/div[2]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(Constants.REQUIRED));
        }

        /*Tests for error when security answer field is empty*/
        [Test]
        [Category("Required Empty Fields Label Test")]
        public void RequiredSecurityAnswerTest()
        {
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[4]/div[3]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(Constants.REQUIRED));
        }

        /*Tests for error when address1 field is empty*/
        [Test]
        [Category("Required Empty Fields Label Test")]
        public void RequiredAddress1Test()
        {
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[5]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(Constants.REQUIRED));
        }

        /*Tests for error when city field is empty*/
        [Test]
        [Category("Required Empty Fields Label Test")]
        public void RequiredCityTest()
        {
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[7]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(Constants.REQUIRED));
        }

        /*Tests for error when state field is empty*/
        [Test]
        [Category("Required Empty Fields Label Test")]
        public void RequiredStateTest()
        {
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[8]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(Constants.REQUIRED));
        }

        /*Tests for error when zip code field is empty*/
        [Test]
        [Category("Required Empty Fields Label Test")]
        public void RequiredZipCodeTest()
        {
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[9]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(Constants.REQUIRED));
        }

        /*Tests for error when telephone field is empty*/
        [Test]
        [Category("Required Empty Fields Label Test")]
        public void RequiredTelephoneTest()
        {
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[10]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(Constants.REQUIRED));
        }


        /*Tests for no error when first name field is filled*/
        [Test]
        [Category("Required Filled Fields Label Test")]
        public void FilledFirstNameTest()
        {
            createAnAccountModel.EnterFirstName("xxx");
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[1]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(string.Empty));
        }

        /*Tests for no error when last name field is filled*/
        [Test]
        [Category("Required Filled Fields Label Test")]
        public void FilledLastNameTest()
        {
            createAnAccountModel.EnterLastName("xxx");
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[2]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(string.Empty));
        }

        /*Tests for no error when email field is filled*/
        [Test]
        [Category("Required Filled Fields Label Test")]
        public void FilledEmailTest()
        {
            createAnAccountModel.EnterEmail("xxx");
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[3]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(string.Empty));
        }

        /*Tests for no error when password field is filled*/
        [Test]
        [Category("Required Filled Fields Label Test")]
        public void FilledPasswordTest()
        {
            createAnAccountModel.EnterPassword("T3sting.222");
            Thread.Sleep(1000);
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[4]/div[1]/div[1]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(string.Empty));
            FilledConfirmPasswordTest();
        }

        /*Tests for no error when confirm password field is filled*/
        //[Test]
        //[Category("Required Filled Fields Label Test")]
        public void FilledConfirmPasswordTest()
        {
            createAnAccountModel.EnterConfirmPassword("T3sting.222");
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[4]/div[1]/div[2]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(string.Empty));
        }

        /*Tests for no error when security question field is filled*/
        [Test]
        [Category("Required Filled Fields Label Test")]
        public void FilledSecurityQuestionTest()
        {
            createAnAccountModel.SelectSecurityQuestion(0);
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[4]/div[2]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(string.Empty));
        }

        /*Tests for no error when security answer field is filled*/
        [Test]
        [Category("Required Filled Fields Label Test")]
        public void FilledSecurityAnswerTest()
        {
            createAnAccountModel.EnterSecurityAnswer("xxx");
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[4]/div[3]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(string.Empty));
        }

        /*Tests for no error when Address 1 field is filled*/
        [Test]
        [Category("Required Filled Fields Label Test")]
        public void FilledAddress1Test()
        {
            createAnAccountModel.EnterAddress1("xxx");
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[5]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(string.Empty));
        }

        /*Tests for no error when city field is filled*/
        [Test]
        [Category("Required Filled Fields Label Test")]
        public void FilledCityTest()
        {
            createAnAccountModel.EnterCity("xxx");
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[7]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(string.Empty));
        }

        /*Tests for no error when state field is filled*/
        [Test]
        [Category("Required Filled Fields Label Test")]
        public void FilledStateTest()
        {
            createAnAccountModel.SelectState(0);
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[8]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(string.Empty));
        }

        /*Tests for no error when zip code field is filled*/
        [Test]
        [Category("Required Filled Fields Label Test")]
        public void FilledZipCodeTest()
        {
            createAnAccountModel.EnterZipCode("xxx");
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[9]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(string.Empty));
        }

        /*Tests for no error when telephone field is filled*/
        [Test]
        [Category("Required Filled Fields Label Test")]
        public void FilledTelephoneTest()
        {
            createAnAccountModel.EnterPhone("xxx");
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[10]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(string.Empty));
        }


    }
}
