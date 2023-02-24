using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using AngleSharp.Dom;

namespace WebDriverUtility
{
    public static class WebDriverUtility
    {
        private static IWebDriver? driver { get; set; }
        private static WebDriverWait? wait { get; set; }

        public static IWebDriver UIWebDriver { get { return driver; } }

        public static void createDriver()
        {
            if (driver == null)
            {
                new DriverManager().SetUpDriver(new ChromeConfig());
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                driver = new ChromeDriver(options);
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }
        }
        public static void LoadPage(string url)
        {
            try
            {
            if (driver != null)
                driver.Navigate().GoToUrl(url);
            }
            catch (System.Exception)
            {

            }
        }

        public static void Tab(IWebElement element)
        {
            try
            {
                element.SendKeys(Keys.Tab);
            }
            catch (System.Exception)
            {

            }
        }

        public static void SelectDropdown(IWebElement element,String option)
        {
            try
            {
                var selection = new SelectElement(element);
                selection.SelectByText(option);
            }
            catch (System.Exception)
            {

            }
        }

        public static void AccepAlert()
        {
            try
            {
                IAlert alert = wait.Until(ExpectedConditions.AlertIsPresent());
                alert.Accept();
            }
            catch (System.Exception)
            {

            }
        }

        public static void EnterKeysAccepAlert( String text)
        {
            try
            {
                IAlert alert = wait.Until(ExpectedConditions.AlertIsPresent());
                alert.SendKeys(text);
                alert.Accept();
            }
            catch (System.Exception)
            {

            }
        }

        public static void SwitchToFrame(IWebElement iframe)
        {
            try
            {
                if (driver != null)
                driver.SwitchTo().Frame(iframe);
            }
            catch (System.Exception)
            {

            }
        }

        public static void SwitchToFrame(int iframe)
        {
            try
            {
                if (driver != null)
                    driver.SwitchTo().Frame(iframe);
            }
            catch (System.Exception)
            {

            }
        }

        public static void SwitchToDefaultContent()
        {
            try
            {
                if (driver != null)
                    driver.SwitchTo().DefaultContent();
            }
            catch (System.Exception)
            {

            }
        }
        public static void NavigateBack(IWebElement element, String option)
        {
            try
            {
                if (driver != null)
                    driver.Navigate().Forward();
            }
            catch (System.Exception)
            {

            }
        }

        public static string? GetAttribute(IWebElement element,string property)
        {
            try
            {
                return element.GetAttribute(property);
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public static void Quit()
        {
            try
            {
                if (driver != null)
                    driver.Quit();
            }
            catch (System.Exception)
            {

            }
        }

        public static void ExtractValue(IList<IWebElement> elements, string? attribute = null)
        {
            IList<string>? values = null;
            try
            {
                if (attribute == null)
                {
                    foreach (IWebElement e in elements)
                    {
                            values.Add(e.Text);
                    }
                }
                else
                {
                    foreach (IWebElement e in elements)
                    {
                            values.Add(e.GetAttribute(attribute));
                    }
                }
            }
            catch (System.Exception)
            {
            }
        }

        public static void SendKeys(IWebElement element, String text)
        {
            try
            {
                element.SendKeys(text);
            }
            catch (System.Exception)
            {

            }
        }

        public static void PressEnter(IWebElement element)
        {
            try
            {
                element.SendKeys(Keys.Enter);
            }
            catch (System.Exception)
            {

            }
        }

        public static void Click(IWebElement element)
        {
            try
            {
                element.Click();
            }
            catch (System.Exception)
            {
            }
        }

        public static bool WaitForElemenXpath(string xpath)
        {
            try
            {
                var element = wait.Until(driver => driver.FindElement(By.XPath(xpath)));
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public static bool WaitForElemenCss(string css)
        {
            try
            {
                var element = wait.Until(driver => driver.FindElement(By.CssSelector(css)));
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public static string TakeScreenshotToPath(string path)
        {
            try
            {
                string filename = path+ ".jpg";
                if (driver != null)
                    ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(filename);
                return filename;
            }
            catch (System.Exception)
            {
                return "Failed To Take Screenshot";
            }
        }
        public static bool ElementIsDisplayed(string xpath)
        {
            try
            {
             if(driver.FindElement(By.XPath(xpath)).Displayed)
                return true;
                return false;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public static bool CssElementIsDisplayed(IWebElement element, string property,string expected)
        {
            try
            {
                bool found = wait.Until((d) =>
                {
                    return element.GetCssValue(property).Equals(expected);
                });
                return found;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}