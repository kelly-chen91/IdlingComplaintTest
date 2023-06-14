using IdlingComplaintTest.Pages.CreateAnAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdlingComplaintTest.Tests.CreateAnAccountTests
{
    internal class CreateAnAccountTestSetUp : WebDriverSetUp
    {
        private CreateAnAccountModel createAnAccountModel;
        [SetUp]
        public void SetUp()
        {
            createAnAccountModel = new CreateAnAccountModel(GetDriver());
            GetDriver().Navigate().GoToUrl("https://nycidling-dev.azurewebsites.net/profile");
        }

        public CreateAnAccountModel GetCreateAnAccountModel()
        {
            return createAnAccountModel;
        }
    }
}
