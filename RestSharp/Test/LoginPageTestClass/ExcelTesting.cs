using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp.Generic.Main;
using RestSharp.Generic.ObjRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharp.Test.LoginPageTestClass
{
    [TestClass]
    public class ExcelTesting : BaseClass
    {
        [TestMethod]
        [TestCategory("Login"), TestCategory("Regression"), TestCategory("Smoke")]
        [Owner("Varun")]
        [DataSource("System.Data.OleDb",
           "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + IPathConstants.excelPath +
           ";Extended Properties=Excel 12.0", "LOGIN2$", DataAccessMethod.Sequential)]
        public void ExcelData()
        {
            _loginPage = new LoginPage(driver);
            //logining in 
            var username = _TestContext.DataRow["USERNAME"].ToString();
            var password = _TestContext.DataRow["Password"].ToString();
            _loginPage.Login(username, password);

            //assertions
            Assert.AreEqual(driver.Title, _TestContext.DataRow["HOMEPAGE_TITLE"], "Title is Not Matching");
            Assert.AreEqual(driver.Url, _TestContext.DataRow["HOMEPAGE_URL"], "Url verification failed");
            Console.WriteLine("adding sub branch");
        }
    }
}
