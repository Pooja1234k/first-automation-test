using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ProfileProject.pages
{
    public class LanguagePage
    {


        public void AddNewLanguages(IWebDriver driver, String Hindi, String Fluent)
        {
            Thread.Sleep(3000);
            IWebElement LanguagesOption = driver.FindElement(By.LinkText("Languages"));
            LanguagesOption.Click();
            

            // Click on Add a new languages
            Thread.Sleep(3000);
            IWebElement AddNewLanguage = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
            AddNewLanguage.Click();
            Thread.Sleep(3000);

            // Enter new valid languages

            IWebElement AddLanguageTextbox = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]"));
            AddLanguageTextbox.SendKeys(Hindi);
            Thread.Sleep(3000);


            // Choose language level from Drop down list


            IWebElement LanguageLevelOption = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/select[1]"));
            SelectElement lDropdown = new SelectElement(LanguageLevelOption);
            lDropdown.SelectByText(Fluent);
            Thread.Sleep(3000);


            // Click on add button

            IWebElement AddButton = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]"));
            AddButton.Click();
            Thread.Sleep(3000);

        }
        public string GetLanguage(IWebDriver driver)
        {
            IWebElement newLanguage = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]"));
            return newLanguage.GetAttribute("outerText").ToString();

        }

        public string GetLanguageLevel(IWebDriver driver)
        {
            IWebElement newLanguageLevel = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]"));
            return newLanguageLevel.GetAttribute("outerText").ToString();
        }


        public void UpdateLanguages(IWebDriver driver, string English, string Basic)
        {
            Thread.Sleep(3000);
            IWebElement LanguagesOption = driver.FindElement(By.LinkText("Languages"));
            LanguagesOption.Click();
            Thread.Sleep(3000);

            IWebElement EditButton = driver.FindElement(By.XPath("//tbody/tr[1]/td[3]/span[1]/i[1]"));
            EditButton.Click();
            Thread.Sleep(3000);

            // edit the Language textbox
            IWebElement editLanguageTextbox = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]"));
            editLanguageTextbox.Clear();
            editLanguageTextbox.SendKeys(English);
            Thread.Sleep(5000);

            // edit the language level textbox
            IWebElement editLanguageLevelTextbox = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[2]/select[1]"));
            SelectElement lDropdown = new SelectElement(editLanguageLevelTextbox);
            lDropdown.SelectByValue(Basic);
            Thread.Sleep(3000);

            //click on update button
            IWebElement UpdateButton = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/span[1]/input[1]"));
            UpdateButton.Click();
            Thread.Sleep(2000);


        }
        public String editedLanguage(IWebDriver driver)
        {
            IWebElement editedLanguage = driver.FindElement(By.XPath("//tbody/tr/td[1]"));
            return editedLanguage.Text;

        }

        public String editedLanguageLevel(IWebDriver driver)
        {
            IWebElement editedLanguageLevel = driver.FindElement(By.XPath("//td[contains(text(),'Basic')]"));
            return editedLanguageLevel.Text;
        }

        public void DeleteLanguages(IWebDriver driver)
        {
            Thread.Sleep(3000);
            IWebElement LanguageOption = driver.FindElement(By.LinkText("Languages"));
            LanguageOption.Click();
           

            IWebElement deleteButton = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));
            deleteButton.Click();
            Thread.Sleep(3000);


        }

        public String deletedLanguage(IWebDriver driver)
        {
            IWebElement deletedLanguage = driver.FindElement(By.XPath("//tbody/tr/td[1]"));
            return deletedLanguage.Text;

        }

        public void validateLanguages(IWebDriver driver)
        {
            Thread.Sleep(3000);
            IWebElement LanguageOption = driver.FindElement(By.LinkText("Languages"));
            LanguageOption.Click();

            Thread.Sleep(3000);
            IWebElement AddNewLanguage = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
            AddNewLanguage.Click();
            Thread.Sleep(3000);

            IWebElement LanguageName = driver.FindElement(By.Name("name"));
            LanguageName.Click();

            IWebElement LevelOption = driver.FindElement(By.Name("level"));
            LevelOption.Click();
            Thread.Sleep(3000);

            IWebElement AddButton = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]"));
            AddButton.Click();
            Thread.Sleep(3000);


        }

        public String validatedLanguage(IWebDriver driver)
        {
            IWebElement validatedLanguage = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]"));
            return validatedLanguage.Text;

        }


    }
        
}