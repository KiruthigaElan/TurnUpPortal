using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace TurnUpPortal.Pages
{
    public class HomePage
    {
        public void NavigateToTM(IWebDriver driver)
        {

            //Navigate to Time and Material Page
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

            IWebElement administrationTab = wait.Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions
                .ElementToBeClickable(By.XPath("//a[contains(text(),'Administration')]")));
           // IWebElement administrationTab = driver.FindElement(By.XPath("//a[contains(text(),'Administration')]"));
            administrationTab.Click();

            IWebElement tmOption = wait.Until(
       SeleniumExtras.WaitHelpers.ExpectedConditions
       .ElementToBeClickable(By.XPath("//a[contains(text(),'Time & Materials')]"))
   );

            //IWebElement selectTimeAndMaterial = driver.FindElement(By.XPath("//a[contains(text(),'Time & Materials')]"));
            tmOption.Click();
        }
    }
}
