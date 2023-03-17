using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RestSharp.Generic.ObjRepo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RestSharp.Generic.Main
{
    [TestClass]
    public class BaseClass
    {

        public static TestContext _TestContext;
        protected IWebDriver driver;
        //declaring the LoginPage
        protected LoginPage _loginPage;
        public HomePage _homePage;

        public CSharp_Utility cSharp_Utility=new CSharp_Utility();
        public WebDriver_Utility webDriver_Utility=new WebDriver_Utility();
        public Excel_Utility excel_Utility=new Excel_Utility();





        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext)
        {
            _TestContext=testContext;
            // Perform any necessary setup before the entire test assembly runs
            
            //MessageBox.Show("AssemblyInitialize");
            
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            // Perform any necessary cleanup after the entire test assembly runs
            
            //MessageBox.Show("AssemblyCleanup");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            
            // Perform any necessary setup before each test method runs
            driver = new ChromeDriver();
            // adding waiting condition for find Elements and find Element
            webDriver_Utility.ImplicitlyWait(driver,20);
            //loginPage object initilization
            _loginPage = new LoginPage(driver);
            driver.Navigate().GoToUrl(_loginPage.url);
            
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // Perform any necessary cleanup after each test method runs
            if (_TestContext.CurrentTestOutcome != UnitTestOutcome.Passed)
            {
                // Define the folder where you want to save the screenshots
                string screenshotFolder = "D:\\VisualStudioRepos\\AzureDevOps\\RestSharp\\RestSharp\\ScreenShot\\";

                // Create the folder if it doesn't exist
                if (!Directory.Exists(screenshotFolder))
                {
                    Directory.CreateDirectory(screenshotFolder);
                }

                // Capture a screenshot and save it in the folder with a timestamp as the file name
                string timestamp = DateTime.UtcNow.ToString("yyyyMMddHHmmss");
                string screenshotFile = Path.Combine(screenshotFolder, $"screenshot_{_TestContext.TestName}_{timestamp}.jpg");
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(screenshotFile, ScreenshotImageFormat.Jpeg);
                _TestContext.AddResultFile(screenshotFolder+ $"screenshot_{_TestContext.TestName}_{timestamp}.jpg");
            }
            driver.Quit();
        
        }

    }
   
}
