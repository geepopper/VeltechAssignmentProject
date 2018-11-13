using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValtechAutoFrameWork.Pages;
using ValtechTestProject.Properties;

namespace ValtechTestProject.Pages
{
    public class HomePage: Base
    {
        [FindsBy(How = How.CssSelector, Using = ".blog-post__listing-header header.block-header h2.block-header__heading")]
        private IWebElement recentBlog;

        [FindsBy(How =How.CssSelector,Using = "div>.bloglisting-compact:nth-child(2)>article>div>h3>a")]
        private IWebElement firstArticle;

        [FindsBy(How =How.Id,Using = "CybotCookiebotDialogBodyButtonAccept")]
        private IWebElement cookies;

        [FindsBy(How =How.CssSelector,Using = "li.navigation__menu__item:nth-child(1) > a:nth-child(1)")]
        private IWebElement About;

        [FindsBy(How = How.CssSelector, Using = "li.navigation__menu__item:nth-child(3) > a:nth-child(1)")]
        private IWebElement Services;

        [FindsBy(How = How.CssSelector, Using = "li.navigation__menu__item:nth-child(2) > a:nth-child(1)")]
        private IWebElement Work;

        [FindsBy(How =How.TagName,Using ="h1")]
        private IWebElement ServiceTag;

        [FindsBy(How = How.TagName, Using = "h1")]
        private IWebElement WorkTag;

        [FindsBy(How = How.TagName, Using = "h1")]
        private IWebElement AboutTag;

        private static IWebDriver _driver;
        protected WebDriverPageOps pageops;
        public HomePage() : base(_driver)
        {
            SetDriver();
            PageFactory.InitElements(_driver, this);
            pageops = new WebDriverPageOps(_driver);
        }
        public static IWebDriver SetDriver()
        {
            string driverConfig = Settings.Default.BROWSER;
            switch (driverConfig)
            {
                case "CHROME":
                    _driver = new ChromeDriver();
                    break;

            }
            _driver.Manage().Window.Maximize();
            return _driver;

        }
        protected void NavigateToApplication()
        {
            string AUT = Settings.Default.AUT;
            pageops.OpenPage(AUT);
        }

        public void verifyLink()
        {
            Assert.IsTrue(pageops.IsDisplayed(recentBlog,false));
        }

        public void ClickFirstArticle()
        {
            acceptCookies();
            firstArticle.Click();
        }

        private void acceptCookies()
        {
            cookies.Click();
        }

        public void getPageTitle()
        {
            Assert.AreEqual(_driver.Title, "Where Experiences are Engineered - Valtech");
           
        }

        public void ClickLink(string link)
        {
            switch (link)
            {
                case "Services":
                    Services.Click();
                    break;
                case "Work":
                    Work.Click();
                    break;
                case "About":
                    About.Click();
                    break;
            }
        }
        public void verifyTagText(string link)
        {
            switch(link)
            {
                case "Services":
                    Assert.AreEqual(ServiceTag.Text, "Services");
                    break;
                case "Work":
                    Assert.AreEqual(WorkTag.Text, "Work");
                    break;
                case "About":
                    Assert.AreEqual(WorkTag.Text, "About");
                    break;
            }
           
        }

        public void EndOfTest()
        {
            _driver.Close();
        }
    }
}
