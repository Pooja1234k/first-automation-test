using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ProfileProject.pages
{
    public class ProfilePage
    {


        public void AddNewLanguages(IWebDriver driver)
        {
            IWebElement LanguagesOption = driver.FindElement(By.LinkText("Languages"));
            LanguagesOption.Click();

            // Click on Add a new languages

            IWebElement AddNewOption = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
            AddNewOption.Click();

            // Enter new valid languages

            IWebElement AddLanguageTextbox = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]"));
            AddLanguageTextbox.SendKeys("Hindi");

            // Choose language level from Drop down list


            IWebElement LanguageLevelOption = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/select[1]"));
            SelectElement lDropdown = new SelectElement(LanguageLevelOption);
            lDropdown.SelectByText("Fluent");

            // Click on add button

            IWebElement AddButton = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]"));
            AddButton.Click();

        }

        public void UpdateLanguages(IWebDriver driver, string English, string Fluent)
        {
            IWebElement EditButton = driver.FindElement(By.XPath("//tbody/tr[1]/td[3]/span[1]/i[1]"));
            EditButton.Click();
            Thread.Sleep(2000);

            // edit the Language textbox
            IWebElement newLanguageTextbox = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]"));
            newLanguageTextbox.Clear();
            newLanguageTextbox.SendKeys(English);

            // edit the language level textbox
            IWebElement newLanguageLevelTextbox = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[2]/select[1]"));
            newLanguageLevelTextbox.Clear();
            newLanguageLevelTextbox.SendKeys(Fluent);

            //click on update button
            IWebElement UpdateButton = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/span[1]/input[1]"));
            UpdateButton.Click();
            Thread.Sleep(2000);


        }

        public void DeleteLanguages(IWebDriver driver)
        {
            IWebElement deleteButton = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));
            deleteButton.Click();
            Thread.Sleep(3000);


        }

        public void AddSkilloption(IWebDriver driver)
        {
            //Go to skill tab
            IWebElement Skilloption = driver.FindElement(By.LinkText("Skills"));
            Skilloption.Click();

            // click on add new Skill button
            IWebElement AddSkilloption = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
            AddSkilloption.Click();

            // Add new skill details
            IWebElement SkillTextbox = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]"));
            SkillTextbox.SendKeys("Communication");

            // Add skill level
            IWebElement SkillLevelTextbox = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[2]/select[1]"));
            SelectElement SkillDropdown = new SelectElement(SkillLevelTextbox);
            SkillDropdown.SelectByText("Expert");

            //click on add button
            IWebElement AddButton = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/span[1]/input[1]"));
            AddButton.Click();

        }

        public void UpdateSkills(IWebDriver driver, string Technical, string Basic)
        {
            IWebElement editButton = driver.FindElement(By.XPath("//tbody/tr[1]/td[3]/span[1]/i[1]"));
            editButton.Click();
            Thread.Sleep(2000);

            // edit the Language textbox
            IWebElement newSkillTextbox = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]"));
            newSkillTextbox.Clear();
            newSkillTextbox.SendKeys(Technical);

            // edit the language level textbox
            IWebElement newLanguageLevelTextbox = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[2]/select[1]"));
            newLanguageLevelTextbox.Clear();
            newLanguageLevelTextbox.SendKeys(Basic);

            //Click on update button
            IWebElement UpdateButton = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/span[1]/input[1]"));
            UpdateButton.Click();
            Thread.Sleep(2000);

        }

        public void DeleteSkills(IWebDriver driver)
        {
            IWebElement DeleteButton = driver.FindElement(By.XPath("//tbody/tr[1]/td[3]/span[2]/i[1]"));
            DeleteButton.Click();
            Thread.Sleep(3000);
        }

        public void AddEducation(IWebDriver driver)
        {

            IWebElement EducationOption = driver.FindElement(By.LinkText("Education"));
            EducationOption.Click();

            // Add new education

            IWebElement AddNewButton = driver.FindElement(By.XPath("//thead/tr[1]/th[6]/div[1]"));
            AddNewButton.Click();

            // Enter College/University name

            IWebElement CollegeTextbox = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]"));
            CollegeTextbox.SendKeys("AUT");

            // Country of College dropdown

            IWebElement CountryOption = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]/select[1]"));
            SelectElement CDropdown = new SelectElement(CountryOption);
            CDropdown.SelectByText("New Zealand");

            // Title dropdown

            IWebElement TitleOption = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/select[1]"));
            SelectElement TDropdown = new SelectElement(TitleOption);
            TDropdown.SelectByText("B.Tech");

            // Enter degree 
            IWebElement DegreeTextbox = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/input[1]"));
            DegreeTextbox.SendKeys("IT");

            // Year dropdown

            IWebElement YearOption = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[3]/select[1]");
            SelectElement YDropdown = new SelectElement(YearOption);
            YDropdown.SelectByText("2012");

            // click on add button
            IWebElement AddButton = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[3]/div[1]/input[1]"));
            AddButton.Click();

        }

        public void UpdateEducation(IWebDriver driver, string AUT, string DiplomaIT)
        {
            IWebElement editButton = driver.FindElement(By.XPath(""));
            editButton.Click();
            Thread.Sleep(2000);

            // edit the  College textbox
            IWebElement newCollegeTextbox = driver.FindElement(By.XPath(""));
            newCollegeTextbox.Clear();
            newCollegeTextbox.SendKeys(AUT);

            // edit the degree textbox
            IWebElement newDegreeTextbox = driver.FindElement(By.XPath(""));
            newDegreeTextbox.Clear();
            newDegreeTextbox.SendKeys(DiplomaIT);

            //Click on update button
            IWebElement UpdateButton = driver.FindElement(By.XPath(""));
            UpdateButton.Click();
            Thread.Sleep(2000);

        }
    }



}