
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

IWebElement PasswordTextbox = driver.FindElement(By.Id("Password"));
PasswordTextbox.SendKeys("123123");

// identify login button and click on it

IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();

// check if the user is loggedin succesfully

IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
Thread.Sleep(1000);

if(helloHari.Text == "Hello hari!")
{ 
Console.WriteLine("logged in successfully ");
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
Thread.Sleep(2000);
IWebElement gotothelastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
gotothelastPageButton.Click();

// Check if the new material is created successfully

IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
if (newCode.Text == "poojatest1")
{
	Console.WriteLine(" new material is created successfully");
}
else
{
	Console.WriteLine(" new material is failed");
}

// -- check if the edit button is working --//

// Click on edit button
Thread.Sleep(3000);
IWebElement EditButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr/td[5]/a[1]"));
EditButton.Click();

// edit the code textbox
IWebElement newcodeTextbox = driver.FindElement(By.Id("Code"));
newcodeTextbox.Clear();
newcodeTextbox.SendKeys("poojatest2");

// edit the description textbox
IWebElement newdesciptionTextbox = driver.FindElement(By.Id("Description"));
newdesciptionTextbox.Clear();
newdesciptionTextbox.SendKeys("poojatest2");


// price tag interactable
IWebElement newpriceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span"));
newpriceTag.Click();

// edit price per unit textbox
IWebElement newPrice = driver.FindElement(By.Id("Price"));

newPrice.SendKeys("20");

// click on save button
IWebElement newsaveButton = driver.FindElement(By.Id("SaveButton"));
newsaveButton.Click();

// -- Delete the record --//

// click on delete button
IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[2]"));
deleteButton.Click();
































// edit the descrption textbox

















































































