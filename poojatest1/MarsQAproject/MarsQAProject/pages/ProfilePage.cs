
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MarsQAProject.pages
{
    public class ProfilePage
    {

        public void GoToProfileOption(IWebDriver driver)
        {
            IWebElement ProfileOption = driver.FindElement(By.XPath(""));
            ProfileOption.Click();
        }
        public void AddNewLanguages(IWebDriver driver)
        {
            IWebElement LanguagesOption = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            LanguagesOption.Click();

            // Click on Add a new languages

            IWebElement AddNewOption = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewOption.Click();

            // Enter new valid languages

            IWebElement AddLanguageTextbox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            AddLanguageTextbox.SendKeys("English");

            // Choose language level from Drop down list


            IWebElement LanguageLevelOption = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            SelectElement lDropdown = new SelectElement(LanguageLevelOption);
            lDropdown.SelectByText("Fluent");

            // Click on add button

            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            AddButton.Click();

        }

        public void UpdateLanguages()
        {

        }

        public void DeleteLanguages()
        {

        }

    }
}
