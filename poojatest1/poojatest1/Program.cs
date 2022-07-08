
// open chrome browser

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();


// launch turnup portal

driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");


// identify username textbox and enter valid username

IWebElement usernameTexbox =  driver.FindElement(By.Id("UserName"));
usernameTexbox.SendKeys("hari");


// identify password textbox and enter valid password

IWebElement usernamePassword = driver.FindElement(By.Id("Password"));
usernamePassword.SendKeys("123123");

// identify login button and click on it

IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();

// check if the user is loggedin succesfully

IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if

	(helloHari.Text == "hello hari!")
{ Console.WriteLine("logged in successfully ");
}
else
{
	Console.WriteLine(" login failed");
}
















