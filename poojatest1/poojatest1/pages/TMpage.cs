

using NUnit.Framework;
using OpenQA.Selenium;
using poojatest1.utilities;

namespace poojatest1.pages
{
    public class TMpage
    {
        public void CreateTM(IWebDriver driver)
        {
            // click on create new

            IWebElement CreateNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CreateNewButton.Click();
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
            priceTextbox.SendKeys("$12.00");

            // click on save button

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            // go to the last page
            Thread.Sleep(2000);
            IWebElement gotothelastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotothelastPageButton.Click();
            Thread.Sleep(2000);
        }

        public string GetCode(IWebDriver driver)
        {
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return newCode.Text;
        }

        public string GetDescription(IWebDriver driver)
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return newDescription.Text;
        }

        public string GetPrice(IWebDriver driver)
        {
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return newPrice.Text;
        }



        public void EditTM(IWebDriver driver,string code,string description,string price)
        {
            // Click on edit button

            Thread.Sleep(2000);
            IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotoLastPageButton.Click();

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            Thread.Sleep(1000);
            editButton.Click();
            Thread.Sleep(2000);

            // edit the code textbox
            IWebElement newcodeTextbox = driver.FindElement(By.Id("Code"));
            newcodeTextbox.Clear();
            newcodeTextbox.SendKeys(code);

            // edit the description textbox
            IWebElement newdesciptionTextbox = driver.FindElement(By.Id("Description"));
            newdesciptionTextbox.Clear();
            newdesciptionTextbox.SendKeys(description);


            // price tag interactable
            IWebElement newpriceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span"));
            IWebElement newPriceTextbox = driver.FindElement(By.Id("Price"));

            newpriceTag.Click();
            newPriceTextbox.Clear();
            newpriceTag.Click();
            newPriceTextbox.SendKeys(price);


            // click on save button
            IWebElement newsaveButton = driver.FindElement(By.Id("SaveButton"));
            newsaveButton.Click();
            Thread.Sleep(3000);

            // check if the material record is edited successfully



            IWebElement gotothelastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            gotothelastPageButton.Click();
            Thread.Sleep(3000);
        }

        public String editedCode(IWebDriver driver)
        {
            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return editedCode.Text;
        }
            public String editedDescription(IWebDriver driver)
        {
            IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return editedDescription.Text;
       
        }

        public String editedPrice(IWebDriver driver)
        {
            IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return editedPrice.Text;
        }


        public void DeleteTM(IWebDriver driver, string code, string description, string price)
        {
            // -- Delete the record --//

            Thread.Sleep(3000);

            IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotoLastPageButton.Click();

            Thread.Sleep(3000);

            // click on delete button
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(3000);

            // click on delete OK button 

            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(3000);

            // Check if the material is deleted successfully

            IWebElement gotothelastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            gotothelastPageButton.Click();
            Thread.Sleep(3000);
        }

            public string deletedCode(IWebDriver driver)
            {
                IWebElement deletedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
                return deletedCode.Text;


            }

            public string deletedDescription(IWebDriver driver)
            {
                IWebElement deletedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
                return deletedDescription.Text;


            }

            public string deletedPrice(IWebDriver driver)

            {
                IWebElement deletedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
                return deletedPrice.Text;

            }


        }


    }


