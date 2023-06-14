using IdlingComplaintTest.Pages.CreateAnAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdlingComplaintTest.Tests.CreateAnAccountTests
{
    [Parallelizable(ParallelScope.Children)]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    internal class RegistrationErrorTests : CreateAnAccountTestSetUp
    {
        //private CreateAnAccountModel createAnAccountModel;
        //[SetUp]
        //public void SetUp()
        //{
        //    createAnAccountModel = new CreateAnAccountModel(GetDriver());
        //    GetDriver().Navigate().GoToUrl("https://nycidling-dev.azurewebsites.net/profile");
        //}

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


    }
}
