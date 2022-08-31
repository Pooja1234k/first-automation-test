using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProfileProject.Utilities;

namespace ProfileProject.pages
{
    public class LanguagePage : CommonDriver
    {
        IWebElement LanguagesOption => driver.FindElement(By.LinkText("Languages"));
        IWebElement AddNewLanguage => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
        IWebElement AddLanguageTextbox => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]"));
        IWebElement LanguageLevelOption => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/select[1]"));
        IWebElement AddButton => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]"));
        IWebElement newLanguage => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]"));
        IWebElement newLanguageLevel => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]"));
        IWebElement EditButton => driver.FindElement(By.XPath("//tbody/tr[1]/td[3]/span[1]/i[1]"));
        IWebElement editLanguageTextbox => driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]"));
        IWebElement editedLanguage => driver.FindElement(By.XPath("//tbody/tr/td[1]"));
        IWebElement editLanguageLevelTextbox => driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[2]/select[1]"));
        IWebElement UpdateButton => driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/span[1]/input[1]"));
        IWebElement editedLanguageLevel => driver.FindElement(By.XPath("//td[contains(text(),'Basic')]"));
        IWebElement LanguageOption => driver.FindElement(By.LinkText("Languages"));

        IWebElement deleteButton => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));

        IWebElement deletedLanguage => driver.FindElement(By.XPath("//tbody/tr/td[1]"));

        IWebElement AddLanguage => driver.FindElement(By.XPath("//th[contains(text(),'Language')]"));

        IWebElement LevelOption => driver.FindElement(By.Name("level"));

        IWebElement validatedLanguage => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]"));
        
        public void AddNewLanguages(String Hindi, String Fluent)
        {
            Thread.Sleep(3000);
            
            LanguagesOption.Click();
            

            // Click on Add a new languages
            
            
            AddNewLanguage.Click();
            Thread.Sleep(3000);

            // Enter new valid languages

            
            AddLanguageTextbox.SendKeys(Hindi);
            Thread.Sleep(3000);

            // Choose language level from Drop down list  
            SelectElement lDropdown = new SelectElement(LanguageLevelOption);
            lDropdown.SelectByText(Fluent);
            Thread.Sleep(3000);


            // Click on add button

            AddButton.Click();
            Thread.Sleep(3000);

        }

        
        public string GetLanguage()
        {
            
            return newLanguage.GetAttribute("outerText").ToString();

        }

        public string GetLanguageLevel()
        {
            
            return newLanguageLevel.GetAttribute("outerText").ToString();
        }


        public void UpdateLanguages( string English, string Basic)
        {
            Thread.Sleep(3000);
       
            LanguagesOption.Click();
            Thread.Sleep(3000);

            
            EditButton.Click();
            Thread.Sleep(3000);

            // edit the Language textbox
            
            editLanguageTextbox.Clear();
            editLanguageTextbox.SendKeys(English);
            Thread.Sleep(5000);

            // edit the language level textbox
            
            SelectElement lDropdown = new SelectElement(editLanguageLevelTextbox);
            lDropdown.SelectByValue(Basic);
            Thread.Sleep(3000);

            //click on update button
            
            UpdateButton.Click();
            Thread.Sleep(2000);


        }
        public String neweditedLanguage()
        {
            
            return editedLanguage.Text;

        }

        public String neweditedLanguageLevel()
        {
            
            return editedLanguageLevel.Text;
        }

        public void DeleteLanguages()
        {
            Thread.Sleep(3000);
            
            LanguageOption.Click();
           

            
            deleteButton.Click();
            Thread.Sleep(3000);


        }

        public String newdeletedLanguage()
        {
            
            return deletedLanguage.Text;

        }

        public void validateLanguages()
        {
            Thread.Sleep(3000);
            
            LanguagesOption.Click();

            AddNewLanguage.Click();
            
            AddLanguage.Click();

            
            LevelOption.Click();
            Thread.Sleep(3000);

            AddButton.Click();
            Thread.Sleep(3000);


        }

        public String newvalidatedLanguage()
        {
            
            return validatedLanguage.Text;

        }


    }
        
}