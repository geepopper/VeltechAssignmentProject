using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using ValtechTestProject.Pages;

namespace ValtechTestProject.Steps
{
    [Binding]
   public class ValtechTestSteps:HomePage
    {
        HomePage homePage = new HomePage();
        [Given(@"I am on valtech website")]
        public void GivenIAmOnValtechWebsite()
        {
            NavigateToApplication();
        }

        [Then(@"I can verify that Recent blogs link is displayed")]
        public void ThenICanVerifyThatRecentBlogsLinkIsDisplayed()
        {
           verifyLink();
        }
        [Then(@"when I click the first article")]
        public void ThenWhenIClickTheFirstArticle()
        {
            ClickFirstArticle();
        }

        [Then(@"I can verify page title")]
        public void ThenICanVerifyPageTitle()
        {
            getPageTitle();
        }

        [When(@"I click (.*) Link")]
        public void WhenIClickServicesLink(string link)
        {
            ClickLink(link);
        }

        [Then(@"I can verify tag texts (.*)")]
        public void ThenICanVerifyTagTextsServices(string link)
        {
            verifyTagText(link);
        }

        [AfterScenario]
        public void TearDown()
        {
            EndOfTest();
        }

    }
}
