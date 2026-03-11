using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using System;
using TurnUpPortal.Pages;
using TurnUpPortal.Utilities;

namespace TurnUpPortal.StepDefinitions
{
    [Binding]
    public class TimeManagementStepDefinitions : CommonDriver
    
{
    [Given("I login into TurnUp portal successfully")]
    public void GivenILoginIntoTurnUpPortalSuccessfully()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddUserProfilePreference("profile.password_manager_leak_detection", false);

        driver = new ChromeDriver(options);

        //Login page object initialization and definition
        LoginPage loginPageobj = new LoginPage();
        loginPageobj.CheckLogin(driver);
    }

    [When("I navigate to Time and Material page")]
    public void WhenINavigateToTimaAndMaterialPage()
    {
        //Home page object initialization and definition
        HomePage homePageobj = new HomePage();
        homePageobj.NavigateToTM(driver);
    }

    [When("I create time record")]
    public void WhenICreateTimeRecord()
    {
        //TM page object initilization and definition
        TMPage tmpageObj = new TMPage();
        tmpageObj.CreateRecord(driver);
    }

    [Then("the record should be created successfully")]
    public void ThenTheRecordShouldBeCreatedSuccessfully()
    {
        TMPage tmpageObj = new TMPage();
        string newCode = tmpageObj.GetCode(driver);
        string newDescription = tmpageObj.GetDescription(driver);
        string newPrice = tmpageObj.GetPrice(driver);

        Assert.That(newCode == "TA Feb", "Time Record has not created successfully");
        Assert.That(newDescription == "TA Feb 2026 Program", "Actual description and expected description does not match");

            Assert.That(newPrice, Is.EqualTo("$1,000.00"), "The price on the table does not match the expected value.");
           // Assert.That(newPrice == "$1,000", "Actual price and expected price does not match");

    }
    }

}

    