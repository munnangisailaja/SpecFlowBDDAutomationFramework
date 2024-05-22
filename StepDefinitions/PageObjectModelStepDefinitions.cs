using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowBDDAutomationFramework.Pages;
using System.Configuration;

namespace SpecFlowBDDAutomationFramework.StepDefinitions
{
    [Binding]
    public sealed class PageObjectModelStepDefinitions
    {
        private IWebDriver driver;        
        HomePage homePage;        
        public PageObjectModelStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }        

        [Given(@"the user is on Home page")]
        public void GivenTheUserIsOnHomePage()
        {
            driver.Manage().Window.Maximize();            
            driver.Url = "https://parabank.parasoft.com/parabank/index.htm";
            Thread.Sleep(4000);
        }        

        [When(@"the user clicks on ""([^""]*)"" link")]
        public void WhenTheUserClicksOnLink(string LinkText)
        {
            homePage = new HomePage(driver);
            homePage.clickOnLinkText(LinkText);
        }

        [Then(@"the user is on ""([^""]*)"" page")]
        public void ThenTheUserIsOnPage(string pageName)
        {
            Assert.That(homePage.getTitle(),Does.Contain(pageName));
        }
    }
}