using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValtechAutoFrameWork.Pages
{
    public class WebDriverPageOps:WebApplications
    {
        private IWebDriver _driver;

        public WebDriverPageOps(IWebDriver driver)
        {
            this._driver = driver;
        }
        public void OpenPage(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }
        public void ClickElement(string elementIdentifier, string locator)
        {
            throw new NotImplementedException();
        }
        public bool IsDisplayed(IWebElement webElement, bool noImplicitWait)
        {
            try
            {
                if (noImplicitWait)
                {
                    var present = false;
                    TimeSpan ImplicitWait = new TimeSpan(0, 0, 0, 30);
                    TimeSpan NoWait = new TimeSpan(0, 0, 0, 0);
                    WebDriverWait wait = new WebDriverWait(_driver, NoWait);
                    try
                    {
                        present = webElement.Displayed;
                    }
                    catch (NoSuchElementException)
                    {
                    }
                    wait = new WebDriverWait(_driver, ImplicitWait);
                    return present;
                }
                else
                {
                    return webElement.Displayed;
                }

            }
            catch
            {
                return false;
            }
        }
        public bool SetValue(string elementIdenfier, string locator, string text, bool verifyInput = false)
        {
            throw new NotImplementedException();
        }

    }
}


