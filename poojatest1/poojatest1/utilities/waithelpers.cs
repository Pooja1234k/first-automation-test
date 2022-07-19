
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace poojatest1.utilities
{
    public class waithelpers
    {

        public static void WaittobeClickable(IWebDriver driver, int Seconds, string locator, string locatorValue)
        {
            var Wait = new WebDriverWait(driver, new TimeSpan(0, 0, Seconds));


            if (locator == "XPath")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }

            if (locator == "Id")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }

            if (locator == "CssSelector")
            {

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
            }
        }
    }
}