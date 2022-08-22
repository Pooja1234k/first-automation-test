
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using ProfileProject.pages;
using ProfileProject.Pages;
using ProfileProject.Utilities;
using TechTalk.SpecFlow;

namespace ProfileProject.StepDefination
{
    [Binding]
    public class ProfileFeatureStepDefinitions : CommonDriver
    {
        SignInNProfilePage SignInNProfilepageObj = new SignInNProfilePage();
        LanguagePage LanguagePageObj = new LanguagePage();
        SkillPage SkillPageObj = new SkillPage();
        EducationPage EducationPageObj = new EducationPage();

        [Given(@"I logged into user account with valid username and password")]
        public void GivenILoggedIntoUserAccountWithValidUsernameAndPassword()
        {
            driver = new ChromeDriver();
            SignInNProfilepageObj.SignInActions(driver);

        }

        [When(@"I navigate to profile page")]
        public void WhenINavigateToProfilePage()
        {
            SignInNProfilepageObj.NavigateProfilePage(driver);
        }

        [Given(@"I logged into website successsfully")]
        public void GivenILoggedIntoWebsiteSuccesssfully()
        {
            driver = new ChromeDriver();
            SignInNProfilepageObj.SignInActions(driver);
        }

        [When(@"I navigate to  languages tab in profile page")]
        public void WhenINavigateToLanguagesTabInProfilePage()
        {
            SignInNProfilepageObj.NavigateProfilePage(driver);
        }

        [When(@"I add new '([^']*)','([^']*)'languages details")]
        public void WhenIAddNewLanguagesDetails(string p0, string p1)
        {
            LanguagePageObj.AddNewLanguages(driver, p0, p1);
        }

        [Then(@"the languages details '([^']*)','([^']*)'should be created successfully")]
        public void ThenTheLanguagesDetailsShouldBeCreatedSuccessfully(string p0, string p1)
        {
            String newLanguage = LanguagePageObj.GetLanguage(driver);
            String newLanguageLevel = LanguagePageObj.GetLanguageLevel(driver);


            Assert.That(newLanguage.Contains(p0), "Actual Language and Expected Language do not match");
            Assert.That(newLanguageLevel.Contains(p1), "Actual skill and Expected skill do not match");

        }

        [When(@"I navigate to  languages tab")]
        public void WhenINavigateToLanguagesTab()
        {
            SignInNProfilepageObj.NavigateProfilePage(driver);
        }


        [When(@"I update existing '([^']*)','([^']*)' languages details")]
        public void WhenIUpdateExistingLanguagesDetails(string p0, string p1)
        {
            LanguagePageObj.UpdateLanguages(driver, p0, p1);


        }

        [Then(@"the existing languages details'([^']*)','([^']*)' should be updated successfully")]
        public void ThenTheExistingLanguagesDetailsShouldBeUpdatedSuccessfully(string p0, string p1)
        {
            string editedLanguage = LanguagePageObj.editedLanguage(driver);
            string editedLanguageLevel = LanguagePageObj.editedLanguageLevel(driver);


            Assert.That(editedLanguage == p0, "Actual language and expected language do not match");
            Assert.That(editedLanguageLevel == p1, "Actual language level and expected language level do not match");


        }

        [When(@"I navigate to delete button in languages tab")]
        public void WhenINavigateToDeleteButtonInLanguagesTab()
        {
            SignInNProfilepageObj.NavigateProfilePage(driver);

        }

        [When(@"I deleted existing language details")]
        public void WhenIDeletedExistingLanguageDetails()
        {
            LanguagePageObj.DeleteLanguages(driver);

        }

        [Then(@"the language details should be deleted successfully")]
        public void ThenTheLanguageDetailsShouldBeDeletedSuccessfully()
        {
            string deletedLanguage = LanguagePageObj.deletedLanguage(driver);

            Assert.That(deletedLanguage != "English", "Actual language and expected language do not match");

        }

        [When(@"I navigate to skills tab in profile page")]
        public void WhenINavigateToSkillsTabInProfilePage()
        {
            SignInNProfilepageObj.NavigateProfilePage(driver);
        }

        [When(@"I add new '([^']*)','([^']*)'skills details")]
        public void WhenIAddNewSkillsDetails(string p0, string p1)
        {

            SkillPageObj.AddNewSkills(driver, p0, p1);
        }

        [Then(@"the skills details '([^']*)','([^']*)'should be created successfully")]
        public void ThenTheSkillsDetailsShouldBeCreatedSuccessfully(string p0, string p1)
        {
            String newSkill = SkillPageObj.GetSkill(driver);
            String newSkillLevel = SkillPageObj.GetSkillLevel(driver);


            Assert.That(newSkill.Contains(p0), "Actual Skill and Expected Skill do not match");
            Assert.That(newSkillLevel.Contains(p1), "Actual skill level and Expected skill level do not match");

        }
        [When(@"I navigate to edit button in skills tab")]
        public void WhenINavigateToEditButtonInSkillsTab()
        {
            SignInNProfilepageObj.NavigateProfilePage(driver);
        }

        [When(@"I update existing '([^']*)','([^']*)' skills details")]
        public void WhenIUpdateExistingSkillsDetails(string p0, string p1)
        {
            SkillPageObj.UpdateSkills(driver, p0, p1);
        }

        [Then(@"the existing skills details '([^']*)','([^']*)' should be updated successfully")]
        public void ThenTheExistingSkillsDetailsShouldBeUpdatedSuccessfully(string p0, string p1)
        {
            string editedSkill = SkillPageObj.editedSkill(driver);
            string editedSkillLevel = SkillPageObj.editedSkillLevel(driver);


            Assert.That(editedSkill == p0, "Actual Skill and expected Skill do not match");
            Assert.That(editedSkillLevel == p1, "Actual Skill level and expected Skill level do not match");
        }

        [When(@"I navigate to delete button")]
        public void WhenINavigateToDeleteButton()
        {
            SignInNProfilepageObj.NavigateProfilePage(driver);
        }

        [When(@"I deleted existing skills details")]
        public void WhenIDeletedExistingSkillsDetails()
        {
            SkillPageObj.DeleteSkills(driver);
        }

        [Then(@"the skills details should be deleted successfully")]
        public void ThenTheSkillsDetailsShouldBeDeletedSuccessfully()
        {
            string deletedSkills = SkillPageObj.deletedSkill(driver);

            Assert.That(deletedSkills != "Technical", "Actual skill is  not deleted ");
        }        

        [When(@"I navigate to education tab in profile page")]
        public void WhenINavigateToEducationTabInProfilePage()
        {
            SignInNProfilepageObj.NavigateProfilePage(driver);

        }
        [When(@"I add new  education details")]
        public void WhenIAddNewEducationDetails()
        {
            EducationPageObj.AddEducation(driver);
        }

        [Then(@"The Education details should be created successfully")]
        public void ThenTheEducationDetailsShouldBeCreatedSuccessfully()
        {
            String newCollege = EducationPageObj.GetCollege(driver);
            String newCountry = EducationPageObj.GetCountry(driver);
            String newTitle = EducationPageObj.GetTitle(driver);
            String newDegree = EducationPageObj.GetDegree(driver);
            String newYear = EducationPageObj.GetYear(driver);




            Assert.That(newCollege == "Messey", "Actual college and expected college does not match");
            Assert.That(newCountry == "New Zealand", "Actual country and expected country does not match");
            Assert.That(newTitle == "B.Tech", "Actual title and expected title does not match");
            Assert.That(newDegree == "IT", "Actual degree and expected degree does not match");
            Assert.That(newYear == "2012", "Actual year and year price does not match");

            driver.Quit();

        }


        [When(@"I navigate to edit button in education tab")]
        public void WhenINavigateToEditButtonInEducationTab()
        {
            SignInNProfilepageObj.NavigateProfilePage(driver);
        }

        [When(@"I update existing '([^']*)','([^']*)' education details")]
        public void WhenIUpdateExistingEducationDetails(string p0, string p1)
        {
            EducationPageObj.UpdateEducation(driver,p0,p1);

        }

        [Then(@"the '([^']*)','([^']*)' education details should be updated successfully")]
        public void ThenTheEducationDetailsShouldBeUpdatedSuccessfully(string p0, string p1)
        {
            string editedCollege = EducationPageObj.editedCollege(driver);
            string editedDegree = EducationPageObj.editedDegree(driver);


            Assert.That(editedCollege == p0, "Actual College and expected College do not match");
            Assert.That(editedDegree == p1, "Actual Degree and expected Degree do not match");


        }

        [When(@"I navigate to delete button in Education tab")]
        public void WhenINavigateToDeleteButtonInEducationTab()
        {
            SignInNProfilepageObj.NavigateProfilePage(driver);

        }

        [When(@"I deleted existing education details")]
        public void WhenIDeletedExistingEducationDetails()
        {
            EducationPageObj.DeleteEducation(driver);
        }

        [Then(@"the education details should be deleted successfully")]
        public void ThenTheEducationDetailsShouldBeDeletedSuccessfully()
        {
            string deletedEducation = EducationPageObj.deletedEducation(driver);

            Assert.That(deletedEducation != "AUT", "Actual college is  not deleted ");

        }



    }

}