
using OpenQA.Selenium;

namespace MarsQAProject.pages
{
    public class SignInPage
    {
        public void SignInActions(IWebDriver driver)
        {

            driver.Manage().Window.Maximize();
			// launch QA Mars website

			driver.Navigate().GoToUrl("http://localhost:5000/Home");

			// Click on signin Button

			IWebElement SignInButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
			SignInButton.Click();


			// identify EmailAddress textbox and enter valid username

			IWebElement EmailTexbox = driver.FindElement(By.XPath("v[1]/input"));
			EmailTexbox.SendKeys("poojakaushal18@gmail.com");


			// identify password textbox and enter valid password

			IWebElement PasswordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
			PasswordTextbox.SendKeys("karankumar2189");

			// click on login button

			IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
			loginButton.Click();


		}
	}
}
