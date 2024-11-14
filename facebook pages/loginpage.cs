using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookInBrowser.Utilities;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace FacebookInBrowser.facebook_pages
{
    public class loginpage
    {   
        public ControlHelper controlHelper;

        private readonly By usernameFieldLocator = By.XPath("(//android.widget.FrameLayout[@resource-id=\"com.facebook.katana:id/(name removed)\"])[2]/android.widget.FrameLayout/android.widget.FrameLayout[2]/android.widget.FrameLayout[1]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.view.ViewGroup/android.widget.EditText");     
        private readonly By passwordFieldLocator = By.XPath("(//android.widget.FrameLayout[@resource-id=\"com.facebook.katana:id/(name removed)\"])[2]/android.widget.FrameLayout/android.widget.FrameLayout[2]/android.widget.FrameLayout[1]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.EditText");
        private readonly By loginButtonLocator = By.XPath("//android.widget.Button[@content-desc=\"Log in\"]/android.view.ViewGroup");
        public string Username { get; set; }
        public string Password { get; set; }
        private readonly IWebDriver driver;
        public loginpage()
        {
            controlHelper = new ControlHelper();
        }
        public void EnterUsername(string username)
        {
            var usernameField = drivers._driver.FindElement(usernameFieldLocator);
            usernameField.SendKeys(username);
        }
        public void EnterPassword(string password)
        {
            var passwordField = drivers._driver.FindElement(passwordFieldLocator);
            passwordField.SendKeys(password);
        }
        public void Login()
        {
            ClickLoginButton();
        }
        public void ClickLoginButton()
        {
            controlHelper.ButtonClick(loginButtonLocator);
        }
        public void LoginWithCredentials(string username, string password)
        {
            Username = username; 
            Password = password; 
            Login();
        }
    }
}
