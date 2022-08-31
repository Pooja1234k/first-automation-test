using OpenQA.Selenium.Chrome;
using ProfileProject.Pages;
using ProfileProject.Utilities;
using TechTalk.SpecFlow;

namespace ProfileProject
{
    [Binding]
    public sealed class ProfileHooks : CommonDriver
    {
        
        

        [BeforeTestRun]

        public static void SignInSteps()
        {
            driver = new ChromeDriver();

            SignInNProfilePage SignInpageObj = new SignInNProfilePage();
            SignInpageObj.SignInActions();


        }

        [AfterTestRun]

        public static void CloseTestRun()
        {
            Thread.Sleep(2000);
            driver.Close();
        }
    }
}