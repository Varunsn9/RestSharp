using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using SeleniumExtras.PageObjects;

namespace RestSharp.Generic.ObjRepo
{
    public class LoginPage
    {
        public string url = "http://localhost:8888/";
        public string title = "vtiger CRM 5 - Commercial Open Source CRM";

        [FindsBy(How = How.Name, Using = "user_name")]
        private IWebElement userName;

        [FindsBy(How = How.Name, Using = "user_password")]
        private IWebElement userPassword;

        [FindsBy(How = How.Id, Using = "submitButton")]
        private IWebElement loginButton;



        public LoginPage(IWebDriver driver) 
        {
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// login method to login to the application
        /// 
        /// </summary>
        /// <param name="username">the method accepts string parameter for username </param>
        /// <param name="password">the method accepts string parameter for password</param>
        public void Login(string username, string password)
        {
            //sending the username to the username text box
            userName.SendKeys(username);
            //sending the password to the password text box 
            userPassword.SendKeys(password);
            //Login in //clicking onlogin button
            loginButton.Submit();
            
        }
    }
}
