


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using poojatest1.pages;

// open chrome browser
IWebDriver driver = new ChromeDriver();

// Login page object initialization and defination

Loginpage LoginpageObj = new Loginpage();
LoginpageObj.LoginActions(driver);


// Homepage object initialization and defination

Homepage HomepageObj = new Homepage();
HomepageObj.GotoTMpage(driver);


// TMpage object initialization and defination

TMpage TMpageObj = new TMpage();
TMpageObj.CreateTM(driver);

// Edit button 
TMpageObj.EditTM(driver);

//Delete Button
TMpageObj.DeleteTM(driver);






































// edit the descrption textbox

















































































