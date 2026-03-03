using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace TurnUpPortal.Pages
{
   public class LoginPage
    {
        public void CheckLogin(IWebDriver driver)
        {
            /*
             //Open Chrome Browser
            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("profile.password_manager_leak_detection", false);
            driver = new ChromeDriver(options);
            */
             

            //Launching TurnUp Portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");

            //Maximizing the window
            driver.Manage().Window.Maximize();

            //Identify username textbox and enter valid username
            IWebElement userNameTextBox = driver.FindElement(By.Id("UserName"));
            userNameTextBox.SendKeys("hari");
           // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
           // wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("UserName")));

            //Identify Password textbox and enter valid Password
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("123123");

            //Identify login button and click on it
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();

            //Check if user has logged in successfully
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            wait.Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions
                .ElementIsVisible(By.XPath("//*[@id='logoutForm']/ul/li/a"))
            );
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("User has successfully logged in, Test Passed");
            }
            else
            {
                Console.WriteLine("User has not successfully logged in, Test Failed");
            }

        }
    }
}
