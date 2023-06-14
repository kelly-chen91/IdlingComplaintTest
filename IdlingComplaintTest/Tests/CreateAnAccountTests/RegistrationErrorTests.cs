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


        public void ValidPhoneNumberTest()
        {
            //Console.WriteLine(createAnAccountModel.IsValidPhoneNumber("917770-0000"));
            /* The program does not test for valid phone numbers */
        }

        [Test]
        [Category("Required Fields Label Test")]
        public void RequiredFirstNameTest()
        {
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[1]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(Constants.REQUIRED));
        }

        [Test]
        [Category("Required Fields Label Test")]
        public void RequiredLastNameTest()
        {
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[2]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(Constants.REQUIRED));
        }

        [Test]
        [Category("Required Fields Label Test")]
        public void RequiredEmailTest()
        {
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[3]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(Constants.REQUIRED));
        }

        [Test]
        [Category("Required Fields Label Test")]
        public void RequiredPasswordTest()
        {
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[4]/div[1]/div[1]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(Constants.PASSWORD_REQUIRED));
        }

        [Test]
        [Category("Required Fields Label Test")]
        public void RequiredConfirmPasswordTest()
        {
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[4]/div[1]/div[2]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(Constants.PASSWORD_REQUIRED));
        }

        [Test]
        [Category("Required Fields Label Test")]
        public void RequiredSecurityQuestionTest()
        {
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[4]/div[1]/div[2]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(Constants.PASSWORD_REQUIRED));
        }

        [Test]
        [Category("Required Fields Label Test")]
        public void RequiredConfirmPasswordTest()
        {
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[4]/div[1]/div[2]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(Constants.PASSWORD_REQUIRED));
        }

        [Test]
        [Category("Required Fields Label Test")]
        public void RequiredConfirmPasswordTest()
        {
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[4]/div[1]/div[2]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(Constants.PASSWORD_REQUIRED));
        }

        [Test]
        [Category("Required Fields Label Test")]
        public void RequiredConfirmPasswordTest()
        {
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[4]/div[1]/div[2]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(Constants.PASSWORD_REQUIRED));
        }

        [Test]
        [Category("Required Fields Label Test")]
        public void RequiredConfirmPasswordTest()
        {
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[4]/div[1]/div[2]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(Constants.PASSWORD_REQUIRED));
        }

        [Test]
        [Category("Required Fields Label Test")]
        public void RequiredConfirmPasswordTest()
        {
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[4]/div[1]/div[2]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(Constants.PASSWORD_REQUIRED));
        }

        [Test]
        [Category("Required Fields Label Test")]
        public void RequiredConfirmPasswordTest()
        {
            string error = createAnAccountModel.ExtractTextFromXPath("//mat-card-content/div[4]/div[1]/div[2]/mat-form-field/div/div[3]/div/mat-error/text()");
            Assert.That(error, Is.EqualTo(Constants.PASSWORD_REQUIRED));
        }





    }
}
