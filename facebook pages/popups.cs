using OpenQA.Selenium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Appium.Android;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookInBrowser.Utilities;

namespace FacebookInBrowser.pages
{
    public class popups
    {
        public ControlHelper controlHelper;
        public popups()
        {
            controlHelper = new ControlHelper();
        }
        By cancel = By.XPath("//android.widget.ImageView[@content-desc=\"Cancel\"]");
        By user = By.XPath("(//android.widget.FrameLayout[@resource-id=\"com.facebook.katana:id/(name removed)\"])[2]/android.widget.FrameLayout/android.widget.FrameLayout[2]/android.widget.FrameLayout[1]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.view.ViewGroup/android.widget.EditText");
        By pass = By.XPath("(//android.widget.FrameLayout[@resource-id=\"com.facebook.katana:id/(name removed)\"])[2]/android.widget.FrameLayout/android.widget.FrameLayout[2]/android.widget.FrameLayout[1]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.EditText");

        public void Cancelsavedcredentials()
        {
            controlHelper.ButtonClick(cancel);
        }
        public void Selectusername()
        {
            controlHelper.ButtonClick(user);
        }
        public void Selectpassword()
        {
            controlHelper.ButtonClick(pass);
        }
    }
}
