using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using IdlingComplaintTest.Pages.Login;

namespace IdlingComplaintTest.Tests.LoginTests;

[Parallelizable(ParallelScope.Children)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
/*This is user login verification test
 */

internal class LoginVerificationTest : WebDriverSetUp
{
    private LoginModel loginModel;

    [SetUp]
    public void Setup()
    {
        loginModel = new LoginModel(GetDriver());
        GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
    }

    //Explicit wait to test user login 
    [Test]
    [Category("Valid Login")]
    public void ExplicitWaitValidLogin()
    {
        //locate login field
        loginModel.EnterEmail("ttseng@dep.nyc.gov");
        Thread.Sleep(5000);
        loginModel.EnterPassword("Testing1#");
        loginModel.ClickLoginButton();
        GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
        var wait = new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(10)); //1 - too short
        wait.Until(d => d.FindElement(By.CssSelector("button[routerlink='idlingcomplaint/new']")));
        //Assert.IsNotNull(wait);
    }

    [Test]
    [Category("Valid Login")]
    public void ImplicitWaitValidLogin()
    {
        //locate login field
        loginModel.EnterEmail("ttseng@dep.nyc.gov");
        loginModel.EnterPassword("Testing1#");
        loginModel.ClickLoginButton();
        var newComplaintButton = GetDriver().FindElement(By.CssSelector("button[routerlink = 'idlingcomplaint/new']"));
        //Assert.That(GetDriver().FindElement(By.CssSelector("button[routerlink='idlingcomplaint/new']")), !Is.Null);
        Assert.IsNotNull(newComplaintButton);

    }

    //Explicit wait to test user login 
    [Test]
    [Category("Invalid Login")]
    public void ExplicitWaitInvalidLogin()
    {
        //locate login field
        loginModel.EnterEmail("ttseng@dep.nyc.gov");
        loginModel.EnterPassword("Testing1");
        loginModel.ClickLoginButton();
        GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
        var wait = new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(10)); //1 - too short
        wait.Until(d => d.FindElement(By.CssSelector("button[routerlink='idlingcomplaint/new']")));
    }

    //Email/Password does not match
    [Test]
    [Category("Invalid Login")]
    public void ImplicitWaitInvalidLogin()
    {
        //locate login field
        loginModel.EnterEmail("ttseng@dep.nyc.gov");
        loginModel.EnterPassword("Testing1");
        loginModel.ClickLoginButton();
        var newComplaintButton = GetDriver().FindElement(By.CssSelector("button[routerlink = 'idlingcomplaint/new']"));
        Assert.IsNull(newComplaintButton);

    }
}
