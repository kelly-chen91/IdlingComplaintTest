﻿using IdlingComplaintTest.Pages.CreateAnAccount;
using IdlingComplaintTest.Pages.Login;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdlingComplaintTest.Tests.CreateAnAccountTests
{
    internal class RegistrationSuccessTest : DriverSetUp.DriverSetUp
    {
        private CreateAnAccountModel createAnAccountModel;

        [SetUp]
        public new void SetUp()
        {
            createAnAccountModel = new CreateAnAccountModel(GetDriver());
            GetDriver().Navigate().GoToUrl("https://nycidling-dev.azurewebsites.net/profile");
            GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        [Test]
        [Category("Successful Registration Test")]
        public void ImplicitWaitSuccessfulRegistrationTest()
        {
            createAnAccountModel.EnterFirstName("Jane");
            createAnAccountModel.EnterLastName("Doe");
            createAnAccountModel.EnterEmail("kellychen966@gmail.com");
            createAnAccountModel.EnterPassword("T3sting@1234");
            createAnAccountModel.EnterConfirmPassword("T3sting@1234");
            createAnAccountModel.SelectSecurityQuestion(0);
            createAnAccountModel.EnterSecurityAnswer("Testing");
            createAnAccountModel.EnterAddress1("59-17 Junction Blvd");
            createAnAccountModel.EnterAddress2("10th Fl");
            createAnAccountModel.EnterCity("Queens");
            createAnAccountModel.SelectState(0);
            createAnAccountModel.EnterZipCode("11373");
            createAnAccountModel.EnterPhone("631-632-9800");
            createAnAccountModel.ScrollToButton();
            createAnAccountModel.ClickSubmitButton();
            var loginButton = GetDriver().FindElement(By.XPath("/html/body/app-root/div/app-login/mat-card/mat-card-content/form/div[3]/button"));
            Assert.IsNotNull(loginButton);
            Thread.Sleep(60000);
        }
    }
}
