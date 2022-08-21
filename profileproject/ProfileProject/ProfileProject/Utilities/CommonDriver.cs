
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProfileProject.Pages;

namespace ProfileProject.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;
        SignInNProfilePage SignInpageObj = new SignInNProfilePage();


        [SetUp]

        public void SignInSteps()
        {
            driver = new ChromeDriver();
            
            SignInpageObj.SignInActions(driver);
            

        }

        [TearDown]

        public void CloseTestRun()
        {
            Thread.Sleep(2000);
            driver.Close();
        }
    }
}
