using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TurnUpPortal.Pages;
using TurnUpPortal.Utilities;

namespace TurnUpPortal.Tests
{
    [TestFixture]
    public class TM_Tests : CommonDriver
    {
       // IWebDriver driver = null!;
        [SetUp]
       
        public void SetUpSets()

        {

            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("profile.password_manager_leak_detection", false);

            driver = new ChromeDriver(options);

            //Login page object initialization and definition
            LoginPage loginPageobj = new LoginPage();
            loginPageobj.CheckLogin(driver);

            //Home page object initialization and definition
            HomePage homePageobj = new HomePage();
            homePageobj.NavigateToTM(driver);

        }
        
        [Test]
        public void CreateTimeTest()
        {
            //TM page object initilization and definition
            TMPage tmpageObj = new TMPage();
            tmpageObj.CreateRecord(driver);
        }
       /* [Test]
        public void EditTime_Test()
        {

        }
        [Test]
        public void DeleteTime_Test()
        {

        }
        */
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }

}
