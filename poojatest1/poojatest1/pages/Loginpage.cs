
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace poojatest1.pages
{
	public class Loginpage
	{

		public void LoginActions(IWebDriver driver)
		{
			
			driver.Manage().Window.Maximize();


			// launch turnup portal

			driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
			


			// identify username textbox and enter valid username

			IWebElement usernameTexbox = driver.FindElement(By.Id("UserName"));
			usernameTexbox.SendKeys("hari");


			// identify password textbox and enter valid password

			IWebElement PasswordTextbox = driver.FindElement(By.Id("Password"));
			PasswordTextbox.SendKeys("123123");

			// click on login button

			IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
			loginButton.Click();


		}

	}
}
