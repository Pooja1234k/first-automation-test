

using NUnit.Framework;
using OpenQA.Selenium;

namespace ProfileProject.Pages
{
    public class SignInNProfilePage
    {

		public void SignInActions(IWebDriver driver)
		{

			driver.Manage().Window.Maximize();


			// launch website

			driver.Navigate().GoToUrl("http://localhost:5000/Home");
			try
			{

				// identify SignIn button

				IWebElement SignInButton = driver.FindElement(By.LinkText("Sign In"));
				SignInButton.Click();
				Thread.Sleep(2000);

				// identify Email textbox and enter valid Email

				IWebElement EmailTextbox = driver.FindElement(By.XPath("//body/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/input[1]"));
				EmailTextbox.SendKeys("poojakaushal18@gmail.com");
				Thread.Sleep(2000);

				// identify password textbox and enter valid password

				IWebElement passwordTextBox = driver.FindElement(By.XPath("//body/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/input[1]"));
				passwordTextBox.SendKeys("karankumar2189");
				Thread.Sleep(2000);

				// click on login button

				IWebElement LoginButton = driver.FindElement(By.XPath("//button[contains(text(),'Login')]"));
				LoginButton.Click();
				Thread.Sleep(2000);
			}
			catch(Exception ex)
            {
				Assert.Fail("Could not launch the website", ex.Message);
            }

		}

		public void NavigateProfilePage(IWebDriver driver)
        {
			IWebElement Profilepage = driver.FindElement(By.LinkText("Profile"));
			Profilepage.Click();
			Thread.Sleep(5000);
		}

		}
	}
