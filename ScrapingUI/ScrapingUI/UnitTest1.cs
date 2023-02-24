using CommonsUtility;
using NLog.Web;
using OpenQA.Selenium.DevTools;
using ScrapingUI.PageObjects;
using System.Reflection.Metadata;
using WebDriverUtility;

namespace ScrapingUI
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("Output:" + RandomGenerator.RandomNumber(lenght: 5));
            Console.WriteLine("Output:" + RandomGenerator.RandomNumber());
            Console.WriteLine("Output:" + RandomGenerator.guid().ToString());
            Console.WriteLine("Output:" + RandomGenerator.dateRandom());
            Console.WriteLine("Output:" + DefaultNames.fileNames.Reports);
            var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            try
            {
                logger.Debug("Init main");
                logger.Error("test");
            }
            catch (System.Exception)
            {
                NLog.LogManager.Shutdown();
            }
            WebDriverUtility.WebDriverUtility.createDriver();
            WebDriverUtility.WebDriverUtility.LoadPage("https://www.google.com/");
            FlexObject flexObject = new FlexObject(WebDriverUtility.WebDriverUtility.UIWebDriver);
            WebDriverUtility.WebDriverUtility.SendKeys(flexObject.searchbox, "Test");
            WebDriverUtility.WebDriverUtility.Tab(flexObject.searchbox);
            WebDriverUtility.WebDriverUtility.Click(flexObject.GoogleButton);

        }
    }
}