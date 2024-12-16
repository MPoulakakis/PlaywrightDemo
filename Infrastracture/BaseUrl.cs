using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightDemo.Infrastracture
{
    public class BaseUrl : PageTest
    {
        private string? _baseUrl;

        [SetUp]
        public async Task Setup()
        {
            _baseUrl = Environment.GetEnvironmentVariable("BASE_URL");
            if (string.IsNullOrEmpty(_baseUrl))
            {
                throw new InvalidOperationException("BASE_URL environment variable is not set.");
            }
            await Page.GotoAsync(_baseUrl);
        }
    }
}
