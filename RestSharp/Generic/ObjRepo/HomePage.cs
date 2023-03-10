using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharp.Generic.ObjRepo
{
    public class HomePage
    {
        public string title = "Administrator - Home - vtiger CRM 5 - Commercial Open Source CRM";
        public string url = "http://localhost:8888/index.php?action=index&module=Home";
    
        public HomePage(IWebDriver driver) 
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
