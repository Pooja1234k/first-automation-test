
// open chrome browser

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();


// launch turnup portal

driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
Thread.Sleep(1000);


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
// -- create a new material record -- //

// click on administration tab

Thread.Sleep(1500);
IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationTab.Click();

// select time and material from dropdown list

IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmOption.Click();
Thread.Sleep(1500);

// click on create new

IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
createNewButton.Click();
Thread.Sleep(2000);

// input code

IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("poojatest1");

// input descrption

IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
descriptionTextbox.SendKeys("poojatest1");

// making price tag interacable

IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span"));
priceTag.Click();


// input price perunit

IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
priceTextbox.SendKeys("12");

// click on save button

IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();

// go to the last page

IWebElement gotothelastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
gotothelastPageButton.Click();

// Check if the new material is created successfully







































































