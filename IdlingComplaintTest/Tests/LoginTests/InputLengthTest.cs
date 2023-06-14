using IdlingComplaintTest.Pages.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IdlingComplaintTest.Tests.LoginTests
{
    [Parallelizable(ParallelScope.Children)]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    internal class InputLengthTest : WebDriverSetUp
    {
        private LoginModel loginModel;
        private const int MAXLENGTH = 50;

        [SetUp]
        public new void SetUp()
        {
            loginModel = new LoginModel(GetDriver());
        }

        //Length of Email is more than 50 characters.
        //Challenge: Should we test if the user have a valid email address/password? 
        [Test]
        [Category("Invalid Email/Password Length")]
        public void LongEmailInputLength()
        {
            loginModel.EnterEmail("sadjklfsaiwerkladjfskljfdsajkflsdjaklfjdsklfiorjkljklfsdaklsjkldafsd");
            string email = loginModel.GetEmailValue();
            //Assert.That(email.Contains("@"), Is.EqualTo(true)); //checks if the email is valid
            Assert.That(email.Length, Is.LessThanOrEqualTo(MAXLENGTH)); //checks that the email length is <= MAXLENGTH chars
            Assert.That(email, Is.EqualTo("Sadjklfsaiwerkladjfskljfdsajkflsdjaklfjdsklfiorjkl")); //checks that the email cuts off to MAXLENGTH chars length
        }

        //Length of Password is more than MAXLENGTH characters. 
        [Test]
        [Category("Invalid Email/Password Length")]
        public void LongPasswordInputLength()
        {
            loginModel.EnterPassword("sadjklfsaiwerkladjfskljfdsajkflsdjaklfjdsklfiorjkljklfsdaklsjkldafsd");
            string password = loginModel.GetPasswordValue();
            Assert.That(password.Length, Is.LessThanOrEqualTo(MAXLENGTH)); //checks that the password length is <= MAXLENGTH chars
            Assert.That(password, Is.EqualTo("Sadjklfsaiwerkladjfskljfdsajkflsdjaklfjdsklfiorjkl")); //checks that the password cuts off to MAXLENGTH chars length
        }

        //Length of Email is less than MAXLENGTH characters
        [Test]
        [Category("Valid Email/Password Length")]
        public void ValidEmailInputLength()
        {
            loginModel.EnterEmail("test@gmail.com");
            string email = loginModel.GetEmailValue();
            Assert.That(email.Contains("@"), Is.EqualTo(true)); //checks if the email is valid
            Assert.That(email.Length, Is.LessThanOrEqualTo(MAXLENGTH)); //checks that the email length is <= MAXLENGTH chars
            Assert.That(email, Is.EqualTo("test@gmail.com")); //checks that the email cuts off to MAXLENGTH chars if > MAXLENGTH chars
        }

        //Length of Password is less than MAXLENGTH characters
        [Test]
        [Category("Valid Email/Password Length")]
        public void ValidPasswordInputLength()
        {
            loginModel.EnterPassword("Test99990");
            string password = loginModel.GetPasswordValue();
            Assert.That(password.Length, Is.LessThanOrEqualTo(MAXLENGTH)); //checks that the password length is <= MAXLENGTH chars
            Assert.That(password, Is.EqualTo("Test99990")); //checks that the password cuts off to MAXLENGTH chars if > MAXLENGTH chars
        }

        //Length of Email is equal MAXLENGTH characters
        [Test]
        [Category("Valid Email/Password Length")]
        public void ValidEmailInputAtCutOffLength()
        {
            loginModel.EnterEmail("Sadjklfsaiwerkladjfskljfdsajkflsdjaklfjd@gmail.com");
            string email = loginModel.GetEmailValue();
            Assert.That(email.Contains("@"), Is.EqualTo(true)); //checks if the email is valid
            Assert.That(email.Length, Is.LessThanOrEqualTo(MAXLENGTH)); //checks that the email length is <= MAXLENGTH chars
            Assert.That(email, Is.EqualTo("Sadjklfsaiwerkladjfskljfdsajkflsdjaklfjd@gmail.com")); //checks that the email cuts off to MAXLENGTH chars if > MAXLENGTH chars
        }

        //Length of Password is equal MAXLENGTH characters
        [Test]
        [Category("Valid Email/Password Length")]
        public void ValidPasswordInputAtCutOffLength()
        {
            string password = GenerateRandomString(50);
            loginModel.EnterPassword(password);
            string passwordVal = loginModel.GetPasswordValue();
            Assert.That(passwordVal.Length, Is.LessThanOrEqualTo(MAXLENGTH)); //checks that the password length is <= MAXLENGTH chars
            Assert.That(passwordVal, Is.EqualTo(password)); //checks that the password cuts off to MAXLENGTH chars if > MAXLENGTH chars
        }


        //Length of Email is 0, which is invalid
        [Test]
        [Category("Invalid Email/Password Length")]
        public void EmptyEmailInputLength()
        {
            loginModel.EnterEmail("");
            string email = loginModel.GetEmailValue();
            Assert.That(email, !Is.Empty); //checks that the email is not empty
        }

        [Test]
        [Category("Invalid Email/Password Length")]
        public void EmptyPasswordInputLength()
        {
            loginModel.EnterPassword("");
            string password = loginModel.GetPasswordValue();
            Assert.That(password.Length, Is.LessThanOrEqualTo(MAXLENGTH), "The password has exceeded maxlength."); //checks that the password length is <= MAXLENGTH chars
            Assert.That(password, !Is.Empty, "The passwrod is empty"); //checks that the password is not empty
        }

        [Test]
        public void CheckMaxLengthAttribute()
        {
            int maxLength = MaxLengthAttributeValue(loginModel.GetEmail());
            Assert.That(maxLength, Is.EqualTo(MAXLENGTH));
        }

        [Test]
        public void RandomStringTest()
        {
            string random = GenerateRandomString(10);
            Console.WriteLine(random);
            Assert.That(random.Length, Is.EqualTo(10), "Random string length does not equal to 10");
        }
    }
}
