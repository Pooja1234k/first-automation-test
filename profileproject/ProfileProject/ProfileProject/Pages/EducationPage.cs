

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProfileProject.Utilities;

namespace ProfileProject.Pages
{
    public class EducationPage : CommonDriver
    {
        IWebElement EducationOption => driver.FindElement(By.LinkText("Education"));
        IWebElement AddNewButton => driver.FindElement(By.XPath("//thead/tr[1]/th[6]/div[1]"));
        IWebElement CollegeTextbox => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]"));
        IWebElement CountryOption => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]/select[1]"));
        IWebElement TitleOption => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/select[1]"));

        IWebElement DegreeTextbox => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/input[1]"));

        IWebElement YearOption => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[3]/select[1]"));
        IWebElement AddButton => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[3]/div[1]/input[1]"));

        IWebElement newCollege => driver.FindElement(By.XPath("//td[contains(text(),'Messey')]"));
        IWebElement newCountry => driver.FindElement(By.XPath("//td[contains(text(),'New Zealand')]"));

        IWebElement newTitle => driver.FindElement(By.XPath("//td[contains(text(),'B.Tech')]"));
        IWebElement newDegree => driver.FindElement(By.XPath("//td[contains(text(),'IT')]"));
        IWebElement newYear => driver.FindElement(By.XPath("//td[contains(text(),'2012')]"));

        IWebElement editButton => driver.FindElement(By.XPath("//tbody/tr[1]/td[6]/span[1]/i[1]"));

        IWebElement newCollegeTextbox => driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]"));

        IWebElement newDegreeTextbox => driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[2]/div[2]/input[1]"));

        IWebElement UpdateButton => driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[3]/input[1]"));

       IWebElement new1College => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]"));

        IWebElement new1Degree => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]"));
        IWebElement deleteEducation => driver.FindElement(By.XPath("//tbody/tr[1]/td[6]/span[2]/i[1]"));

        IWebElement deletedEducation => driver.FindElement(By.XPath("//tbody/tr/td[1]"));

        IWebElement AddNewEducation => driver.FindElement(By.XPath("//thead/tr[1]/th[6]/div[1]"));

        IWebElement CollegeName => driver.FindElement(By.Name("instituteName"));

        IWebElement CountryName => driver.FindElement(By.Name("country"));

        IWebElement TitleName => driver.FindElement(By.Name("title"));

        IWebElement DegreeName => driver.FindElement(By.Name("degree"));

        IWebElement YearName => driver.FindElement(By.Name("yearOfGraduation"));

        IWebElement validatedEducation => driver.FindElement(By.Name("instituteName"));
        public void AddEducation()
        {
            
            
            EducationOption.Click();

            // Add new education

            
            AddNewButton.Click();

            // Enter College/University name

        
            CollegeTextbox.SendKeys("Messey");

            // Country of College dropdown

            
            SelectElement CDropdown = new SelectElement(CountryOption);
            CDropdown.SelectByValue("New Zealand");

            // Title dropdown

            
            SelectElement TDropdown = new SelectElement(TitleOption);
            TDropdown.SelectByValue("B.Tech");

            // Enter degree 
            DegreeTextbox.SendKeys("IT");

            // Year dropdown

            
            SelectElement YDropdown = new SelectElement(YearOption);
            YDropdown.SelectByValue("2012");

            // click on add button
            
            AddButton.Click();
            Thread.Sleep(2000);

        }
        public string GetCollege()
        {
            
            return newCollege.Text;

        }

        public string GetCountry()
        {
            
            return newCountry.Text;

        }

        public string GetTitle()
        {
            
            return newTitle.Text;

        }
        public string GetDegree()
        {
            
            return newDegree.Text;

        }

        public string GetYear()
        {
            
            return newYear.Text;

        }


        public void UpdateEducation( string AUT, string DiplomaIT)
        {

           
            
            EducationOption.Click();
            

            
            editButton.Click();
            

            // edit the  College textbox
            
            newCollegeTextbox.Clear();
            newCollegeTextbox.SendKeys(AUT);

            // edit the degree textbox
            
            newDegreeTextbox.Clear();
            newDegreeTextbox.SendKeys(DiplomaIT);

            //Click on update button
            
            UpdateButton.Click();
            Thread.Sleep(5000);

        }
        public String neweditedCollege()
        {
            
            return new1College.GetAttribute("outerText").ToString();


        }

        public String neweditedDegree()
        {
          
            return new1Degree.GetAttribute("outerText").ToString();

        }

        public void DeleteEducation()
        {
            
          
            EducationOption.Click();

            
            deleteEducation.Click();
            Thread.Sleep(3000);
        }

        public String newdeletedEducation()
        {
           
            return deletedEducation.Text;

        }

        public void validateEducation()
        {
            
            //IWebElement EducationOption = driver.FindElement(By.LinkText("Education"));
            EducationOption.Click();

            
            
            AddNewEducation.Click();
            Thread.Sleep(3000);

            
            CollegeName.Click();

            
            CountryName.Click();

            
            TitleName.Click();
            Thread.Sleep(3000);

            
            DegreeName.Click();
            Thread.Sleep(3000);

            
            YearName.Click();
            Thread.Sleep(3000);

            //IWebElement AddButton = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[3]/div[1]/input[1]"));
            AddButton.Click();
            Thread.Sleep(3000);

        }

        public String newvalidatedEducation()
        {
            
            return validatedEducation.Text;

        }
    }

}