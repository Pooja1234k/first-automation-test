

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProfileProject.Utilities;

namespace ProfileProject.Pages
{
    public class SkillPage : CommonDriver
    {

        IWebElement SkillOption => driver.FindElement(By.LinkText("Skills"));
        IWebElement AddSkilloption => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
        IWebElement SkillTextbox => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]"));
        IWebElement SkillLevelTextbox => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[2]/select[1]"));

        IWebElement AddButton => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/span[1]/input[1]"));
        IWebElement newSkill => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]"));
        IWebElement newSkillLevel => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]"));
        IWebElement editButton => driver.FindElement(By.XPath("//tbody/tr[1]/td[3]/span[1]/i[1]"));

        IWebElement editedSkill => driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]"));

        IWebElement editedSkillLevel => driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[2]/select[1]"));

        IWebElement UpdateButton => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/span[1]/input[1]"));

        //IWebElement editedSkill => driver.FindElement(By.XPath("//tbody/tr/td[1]"));

        //IWebElement editedSkillLevel => driver.FindElement(By.XPath("//tbody/tr/td[2]"));
        // IWebElement SkillOption => driver.FindElement(By.LinkText("Skills"));
        IWebElement AddNewSkill => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
        IWebElement deleteButton => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));

        IWebElement deletedSkill => driver.FindElement(By.XPath("//tbody/tr/td[1]"));

        IWebElement SkillName => driver.FindElement(By.Name("name"));

        IWebElement SkillButton => driver.FindElement(By.Name("level"));
        // IWebElement AddButton => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/span[1]/input[1]"));

        IWebElement validatedSkills => driver.FindElement(By.Name("name"));

        public void AddNewSkills(String Communication, String Expert)
        {
            //Go to skill tab
           
            
            SkillOption.Click();


            // click on add new Skill button
            AddSkilloption.Click();
            Thread.Sleep(3000);

            // Add new skill details
           
            SkillTextbox.SendKeys(Communication);
            Thread.Sleep(4000);

            // Add skill level
            
            SelectElement SkillDropdown = new SelectElement(SkillLevelTextbox);
            SkillDropdown.SelectByText(Expert);
            Thread.Sleep(3000);

            //click on add button
            
            AddButton.Click();
            Thread.Sleep(3000);

        }

        public string GetSkill()
        {
            
            return newSkill.GetAttribute("outerText").ToString();

        }

        public string GetSkillLevel()
        {
           
            return newSkillLevel.GetAttribute("outerText").ToString();
        }


        public void UpdateSkills( string Technical, string Beginner)
        {
            Thread.Sleep(3000);
           
            SkillOption.Click();
            Thread.Sleep(3000);


            
            editButton.Click();
            Thread.Sleep(2000);

            // edit the Language textbox
              
              editedSkill.Clear();
              editedSkill.SendKeys(Technical);
            

            // edit the language level textbox
            
            SelectElement SDropdown = new SelectElement(editedSkillLevel);
            SDropdown.SelectByText(Beginner);
            Thread.Sleep(3000);

            //Click on update button
            
            UpdateButton.Click();
            Thread.Sleep(3000);

        }
        public String neweditedSkill()
        {
            
            return editedSkill.Text;

        }

        public String neweditedSkillLevel()
        {
           
            return editedSkillLevel.Text;
        }

        public void DeleteSkills()
        {
            Thread.Sleep(3000);
            
            SkillOption.Click();
            Thread.Sleep(3000);

            
            deleteButton.Click();
            Thread.Sleep(3000);

        }
        public String newdeletedSkill()
        {
            
            return deletedSkill.Text;
        }

        public void validateSkills()
        {
            Thread.Sleep(3000);
            
            SkillOption.Click();

            
            
            AddNewSkill.Click();
            Thread.Sleep(3000);

            
            SkillName.Click();
            Thread.Sleep(3000);

            
            SkillButton.Click();
            Thread.Sleep(3000);


            AddButton.Click();

        }

        public String newvalidatedSkills()
    {
        
        return validatedSkills.Text;

    }
}

}
