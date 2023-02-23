using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace WebDriverUtility
{
    public static class WebDriverUtility
    {
        private static IWebDriver? driver { get; set; }

        public static void createDriver()
        {
            if (driver == null)
            {
                new DriverManager().SetUpDriver(new ChromeConfig());
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                driver = new ChromeDriver(options);
            }
        }
        public static void LoadPage(string url)
        {
            if (driver != null)
                driver.Navigate().GoToUrl(url);
        }
    }
}