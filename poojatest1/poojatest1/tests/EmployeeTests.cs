
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using poojatest1.pages;
using poojatest1.utilities;

namespace poojatest1.tests
{
    [TestFixture]

    [Parallelizable]

    public class EmployeeTests : CommonDriver
    {
       

        Homepage HomePageObj = new Homepage();
        EmployeePage EmployeepageObj = new EmployeePage();

        [Test]
        public void CreateEmployee()
        {

            
            HomePageObj.GotoEmployeePage(driver);
            EmployeepageObj.CreateEmployee(driver);
        }

        [Test]

        public void EditEmployee()
        {

           
            EmployeepageObj.EditEmployee(driver);
        }

        [Test]

        public void DeleteEmployee()
        {

           EmployeepageObj.DeleteEmployee(driver);
        }
        [TearDown]

        public void closingSteps()
        {
            driver.Quit();    
        }
    }
}
