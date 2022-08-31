
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
           // driver = new ChromeDriver();
            //SignInNProfilepageObj.SignInActions();

        }

        [When(@"I navigate to profile page")]
        public void WhenINavigateToProfilePage()
        {
            //SignInNProfilepageObj.NavigateProfilePage();

           // driver.Quit();
        }

        [Given(@"I logged into website successsfully")]
        public void GivenILoggedIntoWebsiteSuccesssfully()
        {
           // driver = new ChromeDriver();
            //SignInNProfilepageObj.SignInActions();
        }

        [When(@"I navigate to  languages tab in profile page")]
        public void WhenINavigateToLanguagesTabInProfilePage()
        {
            //SignInNProfilepageObj.NavigateProfilePage();
        }

        [When(@"I add new '([^']*)','([^']*)'languages details")]
        public void WhenIAddNewLanguagesDetails(string p0, string p1)
        {
            LanguagePageObj.AddNewLanguages( p0, p1);
        }

        [Then(@"the languages details '([^']*)','([^']*)'should be created successfully")]
        public void ThenTheLanguagesDetailsShouldBeCreatedSuccessfully(string p0, string p1)
        {
            String newLanguage = LanguagePageObj.GetLanguage();
            String newLanguageLevel = LanguagePageObj.GetLanguageLevel();


            Assert.That(newLanguage.Contains(p0), "Actual Language and Expected Language do not match");
            Assert.That(newLanguageLevel.Contains(p1), "Actual skill and Expected skill do not match");

            driver.Quit();
        }

        [When(@"I navigate to  languages tab")]
        public void WhenINavigateToLanguagesTab()
        {
           // SignInNProfilepageObj.NavigateProfilePage();
        }


        [When(@"I update existing '([^']*)','([^']*)' languages details")]
        public void WhenIUpdateExistingLanguagesDetails(string p0, string p1)
        {
            LanguagePageObj.UpdateLanguages( p0, p1);


        }

        [Then(@"the existing languages details'([^']*)','([^']*)' should be updated successfully")]
        public void ThenTheExistingLanguagesDetailsShouldBeUpdatedSuccessfully(string p0, string p1)
        {
            string editedLanguage = LanguagePageObj.neweditedLanguage();
            string editedLanguageLevel = LanguagePageObj.neweditedLanguageLevel();


            Assert.That(editedLanguage == p0, "Actual language and expected language do not match");
            Assert.That(editedLanguageLevel == p1, "Actual language level and expected language level do not match");

          //  driver.Quit();
        }

        [When(@"I navigate to delete button in languages tab")]
        public void WhenINavigateToDeleteButtonInLanguagesTab()
        {
           // SignInNProfilepageObj.NavigateProfilePage();

        }

        [When(@"I deleted existing language details")]
        public void WhenIDeletedExistingLanguageDetails()
        {
            LanguagePageObj.DeleteLanguages();

        }

        [Then(@"the language details should be deleted successfully")]
        public void ThenTheLanguageDetailsShouldBeDeletedSuccessfully()
        {
            string deletedLanguage = LanguagePageObj.newdeletedLanguage();

            Assert.That(deletedLanguage != "English", "Actual language and expected language do not match");

           // driver.Quit();
        }

        [Given(@"I left language field as blank")]
        public void GivenILeftLanguageFieldAsBlank()
        {
           // driver = new ChromeDriver();
            //SignInNProfilepageObj.SignInActions();
           // SignInNProfilepageObj.NavigateProfilePage();
            LanguagePageObj.validateLanguages();
        }

        [Then(@"error message should be displayed for language page")]
        public void ThenErrorMessageShouldBeDisplayedForLanguagePage()
        {
            string validatedLanguage = LanguagePageObj.newvalidatedLanguage();

            Assert.That(validatedLanguage != "Empty","Actual language can not be null");

          //  driver.Quit();


        }

        
        [When(@"I navigate to skills tab in profile page")]
        public void WhenINavigateToSkillsTabInProfilePage()
        {
          //  SignInNProfilepageObj.NavigateProfilePage(driver);
        }

        [When(@"I add new '([^']*)','([^']*)'skills details")]
        public void WhenIAddNewSkillsDetails(string p0, string p1)
        {

            SkillPageObj.AddNewSkills( p0, p1);
        }

        [Then(@"the skills details '([^']*)','([^']*)'should be created successfully")]
        public void ThenTheSkillsDetailsShouldBeCreatedSuccessfully(string p0, string p1)
        {
            String newSkill = SkillPageObj.GetSkill();
            String newSkillLevel = SkillPageObj.GetSkillLevel();


            Assert.That(newSkill.Contains(p0), "Actual Skill and Expected Skill do not match");
            Assert.That(newSkillLevel.Contains(p1), "Actual skill level and Expected skill level do not match");

           // driver.Quit();
        }
        [When(@"I navigate to edit button in skills tab")]
        public void WhenINavigateToEditButtonInSkillsTab()
        {
            //SignInNProfilepageObj.NavigateProfilePage(driver);
        }

        [When(@"I update existing '([^']*)','([^']*)' skills details")]
        public void WhenIUpdateExistingSkillsDetails(string p0, string p1)
        {
            SkillPageObj.UpdateSkills(p0, p1);
        }

        [Then(@"the existing skills details '([^']*)','([^']*)' should be updated successfully")]
        public void ThenTheExistingSkillsDetailsShouldBeUpdatedSuccessfully(string p0, string p1)
        {
            string editedSkill = SkillPageObj.neweditedSkill();
            string editedSkillLevel = SkillPageObj.neweditedSkillLevel();


            Assert.That(editedSkill == p0, "Actual Skill and expected Skill do not match");
            Assert.That(editedSkillLevel == p1, "Actual Skill level and expected Skill level do not match");
            //driver.Quit();
        }

        [When(@"I navigate to delete button")]
        public void WhenINavigateToDeleteButton()
        {
           // SignInNProfilepageObj.NavigateProfilePage(driver);
        }

        [When(@"I deleted existing skills details")]
        public void WhenIDeletedExistingSkillsDetails()
        {
            SkillPageObj.DeleteSkills();
        }

        [Then(@"the skills details should be deleted successfully")]
        public void ThenTheSkillsDetailsShouldBeDeletedSuccessfully()
        {
            string deletedSkills = SkillPageObj.newdeletedSkill();

            Assert.That(deletedSkills != "Technical", "Actual skill is  not deleted ");

           // driver.Quit();
        }



        [Given(@"I left skills field as blank")]
        public void GivenILeftSkillsFieldAsBlank()
        {
           // driver = new ChromeDriver();
            //SignInNProfilepageObj.SignInActions(driver);
            //SignInNProfilepageObj.NavigateProfilePage(driver);
           // SkillPageObj.validateSkills(driver);
        }

        [Then(@"error message should be displayed for skills page")]
        public void ThenErrorMessageShouldBeDisplayedForSkillsPage()
        {
            string validatedSkills = SkillPageObj.newvalidatedSkills();

            Assert.That(validatedSkills != "Empty", "Actual Skill can not be null");

            //driver.Quit();

        }

        [When(@"I navigate to education tab in profile page")]
        public void WhenINavigateToEducationTabInProfilePage()
        {
            //SignInNProfilepageObj.NavigateProfilePage();

        }
        [When(@"I add new  education details")]
        public void WhenIAddNewEducationDetails()
        {
            EducationPageObj.AddEducation();
        }

        [Then(@"The Education details should be created successfully")]
        public void ThenTheEducationDetailsShouldBeCreatedSuccessfully()
        {
            String newCollege = EducationPageObj.GetCollege();
            String newCountry = EducationPageObj.GetCountry();
            String newTitle = EducationPageObj.GetTitle();
            String newDegree = EducationPageObj.GetDegree();
            String newYear = EducationPageObj.GetYear();




            Assert.That(newCollege == "Messey", "Actual college and expected college does not match");
            Assert.That(newCountry == "New Zealand", "Actual country and expected country does not match");
            Assert.That(newTitle == "B.Tech", "Actual title and expected title does not match");
            Assert.That(newDegree == "IT", "Actual degree and expected degree does not match");
            Assert.That(newYear == "2012", "Actual year and year price does not match");

            //driver.Quit();

        }


        [When(@"I navigate to edit button in education tab")]
        public void WhenINavigateToEditButtonInEducationTab()
        {
            //SignInNProfilepageObj.NavigateProfilePage(driver);
        }

        [When(@"I update existing '([^']*)','([^']*)' education details")]
        public void WhenIUpdateExistingEducationDetails(string p0, string p1)
        {
            EducationPageObj.UpdateEducation(p0,p1);

        }

        [Then(@"the '([^']*)','([^']*)' education details should be updated successfully")]
        public void ThenTheEducationDetailsShouldBeUpdatedSuccessfully(string p0, string p1)
        {
            string editedCollege = EducationPageObj.neweditedCollege();
            string editedDegree = EducationPageObj.neweditedDegree();

            Assert.That(editedCollege.Contains(p0) ,"Actual College and expected College do not match");
            Assert.That(editedDegree.Contains(p1), "Actual Degree and expected Degree do not match");
           // driver.Quit();

        }

        [When(@"I navigate to delete button in Education tab")]
        public void WhenINavigateToDeleteButtonInEducationTab()
        {
            //SignInNProfilepageObj.NavigateProfilePage(driver);

        }

        [When(@"I deleted existing education details")]
        public void WhenIDeletedExistingEducationDetails()
        {
            EducationPageObj.DeleteEducation();
        }

        [Then(@"the education details should be deleted successfully")]
        public void ThenTheEducationDetailsShouldBeDeletedSuccessfully()
        {
            string deletedEducation = EducationPageObj.newdeletedEducation();

            Assert.That(deletedEducation != "AUT", "Actual college is  not deleted ");
            //driver.Quit();
        }



        [Given(@"I left education field as blank")]
        public void GivenILeftEducationFieldAsBlank()
        {
           // driver = new ChromeDriver();
            //SignInNProfilepageObj.SignInActions(driver);
            //SignInNProfilepageObj.NavigateProfilePage(driver);
            EducationPageObj.validateEducation();
        }

        [Then(@"error message should be displayed for education page")]
        public void ThenErrorMessageShouldBeDisplayedForEducationPage()
        {
            string validatedEducation = EducationPageObj.newvalidatedEducation();

            Assert.That(validatedEducation != "Empty", "Actual Education can not be null");

            //driver.Quit();
        }

    }

}