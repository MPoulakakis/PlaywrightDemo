using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightDemo.Pages;

public class LoginPage(IPage page)
{
    public ILocator formTitle = page.GetByRole(AriaRole.Heading, new() { Name = "Sign In" });
    public ILocator rejectCookies { get; set; } = page.GetByRole(AriaRole.Button, new() { Name = "Reject" });
    public ILocator emailField { get; set; } = page.GetByLabel("Email or mobile number");
    public ILocator passwordField { get; set; } = page.GetByLabel("Email or mobile number");
    public ILocator signInButton { get; set; } = page.GetByRole(AriaRole.Button, new() { Name = "Sign In" });

    
    //public void CheckUserLoginPage()
    //{
    //    rejectCookies.ClickAsync();
    //}
}