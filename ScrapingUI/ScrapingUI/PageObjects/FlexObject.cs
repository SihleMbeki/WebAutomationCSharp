using AngleSharp.Css;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapingUI.PageObjects
{
    internal class FlexObject
    {
   
        public FlexObject(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "[name='q']")]
        public IWebElement searchbox;

        [FindsBySequence]
        [FindsBy(How = How.CssSelector, Using = "[value='Google Search']", Priority = 0)]
        [FindsBy(How = How.XPath, Using = "(//input[@type='submit' and position()=1])[2]", Priority = 1)]
        public IWebElement GoogleButton;

        [FindsByAll]
        [FindsBy(How = How.TagName, Using = "form", Priority = 0)]
        [FindsBy(How = How.Name, Using = "someForm", Priority = 1)]
        public IWebElement ByAllElement;

    }
}
