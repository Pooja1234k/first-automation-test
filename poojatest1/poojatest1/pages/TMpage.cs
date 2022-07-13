using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

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

        }
        public void EditTM(IWebDriver driver)
        {
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
            IWebElement newPriceTextbox = driver.FindElement(By.Id("Price"));

            newpriceTag.Click();
            newPriceTextbox.Clear();
            newpriceTag.Click();
            newPriceTextbox.SendKeys("15");


            // click on save button
            IWebElement newsaveButton = driver.FindElement(By.Id("SaveButton"));
            newsaveButton.Click();

        }
        public void DeleteTM(IWebDriver driver)
        {
            // -- Delete the record --//

            // click on delete button
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();

            // click on delete OK button 

            driver.SwitchTo().Alert().Accept();
        }
    }

}
