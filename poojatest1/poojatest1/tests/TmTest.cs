

using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using poojatest1.pages;
using poojatest1.utilities;

namespace poojatest1.tests
{
    [TestFixture]

    [Parallelizable]

    public class TmTest : CommonDriver
    {

        Homepage HomePageObj = new Homepage();
        TMpage TMpageObj = new TMpage();

        [Test,Order(1),Description("check if user is able to create material record successfully")]

        public void CreateTMTest()
        {
            
            HomePageObj.GotoEmployeepage(driver);
            TMpageObj.CreateEmployee(driver);

        }

        [Test,Order(2),Description("check if user is able to edit material record successfully.")]
        public void EditTMTest()
        {
           
            HomePageObj.GotoEmployeepage(driver);
            TMpageObj.EditTM(driver);
        }

        [Test,Order(3),Description("check if user is able to delete material record.")]


        public void DeleteTMTest()
        {
            
            HomePageObj.GotoEmployeepage(driver);
            TMpageObj.DeleteTM(driver);
        }

        

    }
}
