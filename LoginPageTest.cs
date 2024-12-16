using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using PlaywrightDemo.Infrastracture;
using PlaywrightDemo.Pages;
using System.Runtime.CompilerServices;

namespace PlaywrightDemo;
public class LoginPageTest : PageTest
{
    private LoginPage _loginPage;

    [SetUp]
    public void BasicTestSetup() 
    {
        _loginPage = new LoginPage(Page);
    }

    [Test]
    public async Task LoginComponents()
    {
        await _loginPage.rejectCookies.ClickAsync();
        await Expect(_loginPage.formTitle).ToBeVisibleAsync();
    }
}