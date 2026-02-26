using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Program
{
    public static void Main(string[] args)
    {
        ChromeOptions options = new ChromeOptions();

        options.AddArgument("--guest");

        //Open Chrome Browser
        IWebDriver driver = new ChromeDriver(options);

        //Launching TurnUp Portal
        driver.Navigate().GoToUrl("http://horse.industryconnect.io/");

        //Maximizing the window
        driver.Manage().Window.Maximize();

        //Identify username textbox and enter valid username
        IWebElement userNameTextBox = driver.FindElement(By.Id("UserName"));
        userNameTextBox.SendKeys("hari");

        //Identify Password textbox and enter valid Password
        IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
        passwordTextBox.SendKeys("123123");

        //Identify login button and click on it
        IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        loginButton.Click();

        //Check if user has logged in successfully
        IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

        if (helloHari.Text == "Hello hari!")
        {
            Console.WriteLine("User has successfully logged in, Test Passed");
        }
        else
        {
            Console.WriteLine("User has not successfully logged in, Test Failed");
        }

        //Create a Time Record

        //Navigate to Time and Material Page
        IWebElement administrationTab = driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[1]/div[1]/ul[1]/li[5]/a[1]"));
        administrationTab.Click();

        IWebElement selectTimeAndMaterial = driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[1]/div[1]/ul[1]/li[5]/ul[1]/li[3]/a[1]"));
        selectTimeAndMaterial.Click();

        //Click on create button
        IWebElement createNewRecord = driver.FindElement(By.XPath("/html[1]/body[1]/div[4]/p[1]/a[1]"));
        createNewRecord.Click();

        //Select time from dropdown
        IWebElement clickTime = driver.FindElement(By.XPath("/html[1]/body[1]/div[4]/form[1]/div[1]/div[1]/div[1]/span[1]/span[1]/span[1]"));
        clickTime.Click();

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
        if(newCode.Text == "TA Feb 2026 Program")
        {
            Console.WriteLine("Time Record has created successfully");
        }
        else
        {
            Console.WriteLine("Time Record has not created successfully");
        }

    }
}