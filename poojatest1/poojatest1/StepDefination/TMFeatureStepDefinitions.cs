using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using poojatest1.pages;
using poojatest1.utilities;
using TechTalk.SpecFlow;

namespace poojatest1.StepDefination
{
	[Binding]


	public class TMFeatureStepDefinitions : CommonDriver
	{

		Loginpage LoginpageObj = new Loginpage();
		Homepage HomePageObj = new Homepage();
		TMpage TmPageObj = new TMpage();

		[Given(@"I logged into turnup portal successfully")]
		public void GivenILoggedIntoTurnupPortalSuccessfully()
		{
			driver = new ChromeDriver();
			LoginpageObj.LoginActions(driver);

		}

		[When(@"I navigate to time and material page")]
		public void WhenINavigateToTimeAndMaterialPage()
		{
			HomePageObj.GotoTMpage(driver);

		}

		[When(@"I create a new material record")]
       
		public void WhenICreateANewMaterialRecord()
		{

			TmPageObj.CreateTM(driver);
		}


        [Then(@"The record should be able to record successfully")]

		public void ThenTheRecordShouldBeAbleToRecordSuccessfully()
		{
			

			String newCode = TmPageObj.GetCode(driver);
			String newDescription = TmPageObj.GetDescription(driver);
			String newPrice = TmPageObj.GetPrice(driver);

			Assert.That(newCode == "poojatest1", "Actual code and expected code does not match");
			Assert.That(newDescription == "poojatest1", "Actual description and expected description does not match");
			Assert.That(newPrice == "$12.00", "Actual price and expected price does not match");

			driver.Quit();
		}

		
		[When(@"I updated the '([^']*)','([^']*)','([^']*)' of an existing material record")]
		public void WhenIUpdatedTheOfAnExistingMaterialRecord(string p0, string p1, string p2)
		{
			TmPageObj.EditTM(driver, p0, p1, p2);

		}

		[Then(@"The record Should have '([^']*)','([^']*)','([^']*)' updated")]
		public void ThenTheRecordShouldHaveUpdated(string p0, string p1, string p2)
		{

			string editedCode = TmPageObj.GetCode(driver);
			string editedDescription = TmPageObj.GetDescription(driver);
			string editedPrice = TmPageObj.GetPrice(driver);

			Assert.That(editedCode == p0, "Actual code and expected code do not match");
			Assert.That(editedDescription == p1, "Actual decription and expected description do not match");
			Assert.That(editedPrice == p2, "Actual price and expected price do not match");

			driver.Quit();
		}

		

		[When(@"I deleted the '([^']*)','([^']*)','([^']*)' of an existing material record")]
		public void WhenIDeletedTheOfAnExistingMaterialRecord(string p0, string p1, string p2)
		{

			TmPageObj.DeleteTM(driver, p0, p1, p2);
			Thread.Sleep(2000);
		}

		[Then(@"The record Should have '([^']*)','([^']*)','([^']*)' deleted")]
		public void ThenTheRecordShouldHaveDeleted(string p0, string p1, string p2)
		{

			string deletedCode = TmPageObj.GetCode(driver);
			string deletedDescription = TmPageObj.GetDescription(driver);
			string deletedPrice = TmPageObj.GetPrice(driver);

			Assert.That(deletedCode != p0, "Actual code is not deleted");
			Assert.That(deletedDescription != p1, "Actual decription is not deleted");
			Assert.That(deletedPrice != p2, "Actual price has not been deleted ");

			driver.Quit();
		}

		
	}
	
}
