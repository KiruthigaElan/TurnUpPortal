using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;

[Binding]
public class Hooks
{
    public static IWebDriver driver;

    [BeforeScenario]
    public void Setup()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddUserProfilePreference("profile.password_manager_leak_detection", false);

        driver = new ChromeDriver(options);
        driver.Manage().Window.Maximize();
    }

    [AfterScenario]
    public void TearDown()
    {
        driver.Quit();
    }
}