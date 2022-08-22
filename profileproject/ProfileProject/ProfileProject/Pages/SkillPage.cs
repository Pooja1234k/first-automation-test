

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ProfileProject.Pages
{
    public class SkillPage
    {
        public void AddNewSkills(IWebDriver driver,String Communication, String Expert)
        {
            //Go to skill tab
            Thread.Sleep(3000);
            IWebElement Skilloption = driver.FindElement(By.LinkText("Skills"));
            Skilloption.Click();
           

            // click on add new Skill button
            IWebElement AddSkilloption = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
            AddSkilloption.Click();
            Thread.Sleep(3000);

            // Add new skill details
            IWebElement SkillTextbox = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]"));
            SkillTextbox.SendKeys(Communication);
            Thread.Sleep(4000);

            // Add skill level
            IWebElement SkillLevelTextbox = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[2]/select[1]"));
            SelectElement SkillDropdown = new SelectElement(SkillLevelTextbox);
            SkillDropdown.SelectByText(Expert);
            Thread.Sleep(3000);

            //click on add button
            IWebElement AddButton = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/span[1]/input[1]"));
            AddButton.Click();
            Thread.Sleep(3000);

        }

        public string GetSkill(IWebDriver driver)
        {
            IWebElement newSkill = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]"));
            return newSkill.GetAttribute("outerText").ToString();

        }

        public string GetSkillLevel(IWebDriver driver)
        {
            IWebElement newSkillLevel = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]"));
            return newSkillLevel.GetAttribute("outerText").ToString();
        }


        public void UpdateSkills(IWebDriver driver, string Technical, string Beginner)
        {
            Thread.Sleep(3000);
            IWebElement SkillOption = driver.FindElement(By.LinkText("Skills"));
            SkillOption.Click();
            Thread.Sleep(3000);


            IWebElement editButton = driver.FindElement(By.XPath("//tbody/tr[1]/td[3]/span[1]/i[1]"));
            editButton.Click();
            Thread.Sleep(2000);

            // edit the Language textbox
              IWebElement editedSkill = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]"));
              editedSkill.Clear();
              editedSkill.SendKeys(Technical);
            

            // edit the language level textbox
            IWebElement editedSkillLevel= driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[2]/select[1]"));
            SelectElement SDropdown = new SelectElement(editedSkillLevel);
            SDropdown.SelectByText(Beginner);
            Thread.Sleep(3000);

            //Click on update button
            IWebElement UpdateButton = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/span[1]/input[1]"));
            UpdateButton.Click();
            Thread.Sleep(4000);

        }
        public String editedSkill(IWebDriver driver)
        {
            IWebElement editedSkill = driver.FindElement(By.XPath("//tbody/tr/td[1]"));
            return editedSkill.Text;

        }

        public String editedSkillLevel(IWebDriver driver)
        {
            IWebElement editedSkillLevel = driver.FindElement(By.XPath("//tbody/tr/td[2]"));
            return editedSkillLevel.Text;
        }

        public void DeleteSkills(IWebDriver driver)
        {
            IWebElement SkillOption = driver.FindElement(By.LinkText("Skills"));
            SkillOption.Click();
            Thread.Sleep(3000);

            IWebElement deleteButton = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));
            deleteButton.Click();
            Thread.Sleep(3000);

        }
        public String deletedSkill(IWebDriver driver)
        {
            IWebElement deletedSkill = driver.FindElement(By.XPath("//td[contains(text(),'Technical')]"));
            return deletedSkill.Text;

        }
    }
}
