

using NUnit.Framework;
using OpenQA.Selenium;
using ProfileProject.Utilities;

namespace ProfileProject.Pages
{
    public class SignInNProfilePage : CommonDriver

    {
		IWebElement SignInButton => driver.FindElement(By.LinkText("Sign In"));

		IWebElement EmailTextbox => driver.FindElement(By.Name("email"));

		IWebElement passwordTextBox => driver.FindElement(By.Name("password"));

		IWebElement LoginButton => driver.FindElement(By.XPath("//button[contains(text(),'Login')]"));

		IWebElement Profilepage => driver.FindElement(By.LinkText("Profile"));


		public void SignInActions()
		{

			driver.Manage().Window.Maximize();


			// launch website

			driver.Navigate().GoToUrl("http://localhost:5000/Home");
			try
			{

				// identify SignIn button

				
				SignInButton.Click();
				Thread.Sleep(2000);

				// identify Email textbox and enter valid Email

				
				EmailTextbox.SendKeys("poojakaushal18@gmail.com");
				Thread.Sleep(2000);

				// identify password textbox and enter valid password

				
				passwordTextBox.SendKeys("karankumar2189");
				Thread.Sleep(2000);

				// click on login button

				
				LoginButton.Click();
				Thread.Sleep(3000);
			}
			catch(Exception ex)
            {
				Assert.Fail("Could not launch the website", ex.Message);
            }

		}

		public void NavigateProfilePage()
        {
			
			Profilepage.Click();
			Thread.Sleep(5000);
		}

		}
	}
