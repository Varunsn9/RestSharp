using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharp.Generic.Main
{
    /// <summary>
    /// WebDriver Methods
    /// </summary>
    public class WebDriver_Utility
    {
        /// <summary>
        /// implicitly waiting condition in seconds
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="seconds"></param>
        public void ImplicitlyWait(IWebDriver driver, int seconds)
        {
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(seconds);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="seconds"></param>
        public void ExplicitlyWaitingCondition(IWebDriver driver,int seconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));

        }
    }
}
