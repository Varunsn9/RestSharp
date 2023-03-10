﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp.Generic.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Generic.ObjRepo;

namespace RestSharp.Test.LoginPageTestClass
{
    [TestClass]
    public class LoginPageTest : BaseClass
    {
        /// <summary>
        /// Test Method for login
        /// </summary>
         
        //positive
        [TestMethod]
        [TestCategory("Login"),TestCategory("Regression"),TestCategory("Smoke")]
        [Owner("Varun")]
        public void LoginTest()
        {
           
            //initilizing
            _loginPage = new LoginPage(driver);
            _homePage=new HomePage(driver);
            //logining in 
            _loginPage.Login("admin", "admin");
            //verify successfully login to homepage
            Assert.AreEqual(driver.Title, _homePage.title,"Title is Not Matching");
            Assert.AreEqual(driver.Url, _homePage.url, "Url verification");

            Console.WriteLine(excel_Utility.ExcelData() );
            
        }

        [TestMethod]
        [TestCategory("Login"), TestCategory("Regression"), TestCategory("Smoke")]
        [Owner("Varun")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",IPathConstants.csvPath,"CsvData#csv",DataAccessMethod.Sequential)]
        public void CSVData()
        {
            _loginPage = new LoginPage(driver);
            _homePage = new HomePage(driver);
            //logining in 
            _loginPage.Login(_TestContext.DataRow[0].ToString(), _TestContext.DataRow[1].ToString());

            int rowCount = _TestContext.DataRow.Table.Rows.Count;
            int columnCount = _TestContext.DataRow.Table.Columns.Count;
            Console.WriteLine(_TestContext.DataRow[0]);
            //assertions
            Assert.AreEqual(driver.Title, _homePage.title, "Title is Not Matching");
            Assert.AreEqual(driver.Url, _homePage.url, "Url verification");

        }
        [TestMethod]
        [TestCategory("Login"), TestCategory("Regression"), TestCategory("Smoke")]
        [Owner("Varun")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", IPathConstants.csvPath, "CsvData#csv", DataAccessMethod.Sequential)]
        public void ExcelData()
        {

        }
    }

}