


using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using poojatest1.pages;

namespace poojatest1.utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;

        [SetUp]

        public void LoginSteps()
        {
            driver = new ChromeDriver();
            Loginpage LoginpageObj = new Loginpage();
            LoginpageObj.LoginActions(driver);

        }

        [TearDown]

        public void CloseTestRun()
        {
            driver.Quit();
        }

    }
}