

using NUnit.Framework;
using OpenQA.Selenium;
using poojatest1.utilities;

namespace poojatest1.pages
{
    public class TMpage
    {
        public void CreateEmployee(IWebDriver driver)
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

        }


        public void EditTM(IWebDriver driver)
        {
            // Click on edit button

            Thread.Sleep(2000);
            IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotoLastPageButton.Click();

            
            IWebElement findCodeRecordCreated = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
           
            if (findCodeRecordCreated.Text == "poojatest1")
            {
               IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                Thread.Sleep(1000);
                editButton.Click();

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
            IWebElement newPriceTextbox = driver.FindElement(By.Id("Price"));

            newpriceTag.Click();
            newPriceTextbox.Clear();
            newpriceTag.Click();
            newPriceTextbox.SendKeys("$15.00");


            // click on save button
            IWebElement newsaveButton = driver.FindElement(By.Id("SaveButton"));
            newsaveButton.Click();
            Thread.Sleep(1500);

            }
            else
            {
                Assert.Fail("Record to be edited hasn't been found. Record not edited");
            }


            // check if the material record is edited successfully

            IWebElement gotothelastPageButton= driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            gotothelastPageButton.Click();
            Thread.Sleep(3000);

            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement editedTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            Assert.That(editedCode.Text == "poojatest2", "Actual code and expected code does not match");
            Assert.That(editedTypeCode.Text == "M", "Actual type code  and expected type code does not match");
            Assert.That(editedDescription.Text == "poojatest2", "Actual description and expected description does not match");
            Assert.That(editedPrice.Text == "$15.00", "Actual price and expected price does not match");

        }
        public void DeleteTM(IWebDriver driver)
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

            IWebElement deletedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            //IWebElement deletedTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement deletedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement deletedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            Assert.That(deletedCode.Text != "poojatest2", "code record has not beeen deleted");
           // Assert.That(deletedTypeCode.Text != "M", "Typecode has not been deleted");
            Assert.That(deletedDescription.Text != "poojatest2", "desciption has not been deleted");
            Assert.That(deletedPrice.Text != "$15.00", "price has not been deleted");

        }


    }


}