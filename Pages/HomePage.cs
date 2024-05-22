using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBDDAutomationFramework.Pages
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        } 

        public void clickOnLinkText(string text)
        {
            driver.FindElement(By.LinkText(text)).Click();                        
        }
        public string getTitle()
        {
            return driver.Title;
        }
    }
}
