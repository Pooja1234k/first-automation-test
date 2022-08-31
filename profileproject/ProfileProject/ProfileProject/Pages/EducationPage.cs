

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ProfileProject.Pages
{
    public class EducationPage
    {
        public void AddEducation(IWebDriver driver)
        {
            Thread.Sleep(3000);
            IWebElement EducationOption = driver.FindElement(By.LinkText("Education"));
            EducationOption.Click();

            // Add new education

            IWebElement AddNewButton = driver.FindElement(By.XPath("//thead/tr[1]/th[6]/div[1]"));
            AddNewButton.Click();

            // Enter College/University name

            IWebElement CollegeTextbox = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]"));
            CollegeTextbox.SendKeys("Messey");

            // Country of College dropdown

            IWebElement CountryOption = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]/select[1]"));
            SelectElement CDropdown = new SelectElement(CountryOption);
            CDropdown.SelectByValue("New Zealand");

            // Title dropdown

            IWebElement TitleOption = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/select[1]"));
            SelectElement TDropdown = new SelectElement(TitleOption);
            TDropdown.SelectByValue("B.Tech");

            // Enter degree 
            IWebElement DegreeTextbox = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/input[1]"));
            DegreeTextbox.SendKeys("IT");

            // Year dropdown

            IWebElement YearOption = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[3]/select[1]"));
            SelectElement YDropdown = new SelectElement(YearOption);
            YDropdown.SelectByValue("2012");

            // click on add button
            IWebElement AddButton = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[3]/div[1]/input[1]"));
            AddButton.Click();
            Thread.Sleep(2000);

        }
        public string GetCollege(IWebDriver driver)
        {
            IWebElement newCollege = driver.FindElement(By.XPath("//td[contains(text(),'Messey')]"));
            return newCollege.Text;

        }

        public string GetCountry(IWebDriver driver)
        {
            IWebElement newCountry = driver.FindElement(By.XPath("//td[contains(text(),'New Zealand')]"));
            return newCountry.Text;

        }

        public string GetTitle(IWebDriver driver)
        {
            IWebElement newTitle = driver.FindElement(By.XPath("//td[contains(text(),'B.Tech')]"));
            return newTitle.Text;

        }
        public string GetDegree(IWebDriver driver)
        {
            IWebElement newDegree = driver.FindElement(By.XPath("//td[contains(text(),'IT')]"));
            return newDegree.Text;

        }

        public string GetYear(IWebDriver driver)
        {
            IWebElement newYear = driver.FindElement(By.XPath("//td[contains(text(),'2012')]"));
            return newYear.Text;

        }


        public void UpdateEducation(IWebDriver driver, string AUT, string DiplomaIT)
        {

            Thread.Sleep(4000);
            IWebElement SkillOption = driver.FindElement(By.LinkText("Education"));
            SkillOption.Click();
            Thread.Sleep(4000);

            IWebElement editButton = driver.FindElement(By.XPath("//tbody/tr[1]/td[6]/span[1]/i[1]"));
            editButton.Click();
            Thread.Sleep(5000);

            // edit the  College textbox
            IWebElement newCollegeTextbox = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]"));
            newCollegeTextbox.Clear();
            newCollegeTextbox.SendKeys(AUT);

            // edit the degree textbox
            IWebElement newDegreeTextbox = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[2]/div[2]/input[1]"));
            newDegreeTextbox.Clear();
            newDegreeTextbox.SendKeys(DiplomaIT);

            //Click on update button
            IWebElement UpdateButton = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[3]/input[1]"));
            UpdateButton.Click();
            Thread.Sleep(5000);

        }
        public String neweditedCollege(IWebDriver driver)
        {
            IWebElement newCollege = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]"));
            return newCollege.GetAttribute("outerText").ToString();


        }

        public String neweditedDegree(IWebDriver driver)
        {
            IWebElement newDegree = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]"));
            return newDegree.GetAttribute("outerText").ToString();

        }

        public void DeleteEducation(IWebDriver driver)
        {
            Thread.Sleep(3000);
            IWebElement LanguageOption = driver.FindElement(By.LinkText("Education"));
            LanguageOption.Click();

            IWebElement DeleteEducation = driver.FindElement(By.XPath("//tbody/tr[1]/td[6]/span[2]/i[1]"));
            DeleteEducation.Click();
            Thread.Sleep(3000);
        }

        public String newdeletedEducation(IWebDriver driver)
        {
            IWebElement deletedEducation = driver.FindElement(By.XPath("//tbody/tr/td[1]"));
            return deletedEducation.Text;

        }

        public void validateEducation(IWebDriver driver)
        {
            Thread.Sleep(3000);
            IWebElement EducationOption = driver.FindElement(By.LinkText("Education"));
            EducationOption.Click();

            Thread.Sleep(3000);
            IWebElement AddNewEducation = driver.FindElement(By.XPath("//thead/tr[1]/th[6]/div[1]"));
            AddNewEducation.Click();
            Thread.Sleep(3000);

            IWebElement CollegeName = driver.FindElement(By.Name("instituteName"));
            CollegeName.Click();

            IWebElement CountryName = driver.FindElement(By.Name("country"));
            CountryName.Click();

            IWebElement TitleName = driver.FindElement(By.Name("title"));
            TitleName.Click();
            Thread.Sleep(3000);

            IWebElement DegreeName = driver.FindElement(By.Name("degree"));
            DegreeName.Click();
            Thread.Sleep(3000);

            IWebElement YearName = driver.FindElement(By.Name("yearOfGraduation"));
            YearName.Click();
            Thread.Sleep(3000);

            IWebElement AddButton = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[3]/div[1]/input[1]"));
            AddButton.Click();
            Thread.Sleep(3000);

        }

        public String newvalidatedEducation(IWebDriver driver)
        {
            IWebElement validatedEducation = driver.FindElement(By.Name("instituteName"));
            return validatedEducation.Text;

        }
    }

}