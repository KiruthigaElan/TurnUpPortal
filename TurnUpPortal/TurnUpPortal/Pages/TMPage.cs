using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TurnUpPortal.Pages
{
    public class TMPage
    {
        public void CreateRecord(IWebDriver driver)
        {
            //Click on create button
            IWebElement createNewRecord = driver.FindElement(By.XPath("/html[1]/body[1]/div[4]/p[1]/a[1]"));
            createNewRecord.Click();

            //Select time from dropdown
            IWebElement clickTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[4]/form[1]/div[1]/div[1]/div[1]/span[1]/span[1]/span[1]"));
            clickTime.Click();

            Thread.Sleep(2000);
            IWebElement selectTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[5]/div[1]/ul[1]/li[2]"));
            selectTime.Click();

            //Type Code into code textbox
            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("TA Feb 2026 Program");

            //Type Description into Description textbox
            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("TA Feb 2026 Program");
            Thread.Sleep(2000);

            //Type Price into Price textbox
            IWebElement priceTextBoxOverLap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextBoxOverLap.Click();

            IWebElement enterPrice = driver.FindElement(By.Id("Price"));
            enterPrice.SendKeys("1000");

            //Click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);

            //Navigate to last page to check if the record has been created
            IWebElement goToLastPage = driver.FindElement(By.XPath("/html[1]/body[1]/div[4]/div[1]/div[1]/div[4]/a[4]/span[1]"));
            goToLastPage.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//div[@class='k-grid-content']//table/tbody/tr[last()]/td[1]"));
            Assert.That(newCode.Text == "TA Feb 2026 Program", "ime Record has not created successfully");
            /*
            if (newCode.Text == "TA Feb 2026 Program")
            {
                Assert.Pass("Time Record has created successfully");
            }
            else
            {
                Assert.Fail("Time Record has not created successfully");
            }
            */
        }
    }
}
