
using OpenQA.Selenium;
using poojatest1.utilities;

namespace poojatest1.pages
{
    public class Homepage
    {

        public void GotoTMpage(IWebDriver driver)
        {
            // click on administration tab

            Thread.Sleep(1500);
            IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationTab.Click();
            waithelpers.WaittobeClickable(driver, 5, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a");

            // select time and material from dropdown list

            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();


        }


        public void GotoEmployeePage(IWebDriver driver)
        {


        }

    }
}
