using FacebookInBrowser.facebook_pages;
using FacebookInBrowser.pages;
using FacebookInBrowser.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FacebookInBrowser.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        public popups Popups;
        public loginpage LoginPage;

        public CalculatorStepDefinitions()
        {
            Popups = new popups();
            LoginPage = new loginpage();
        }  

        [Given(@"I navigate to the Facebook login page")]
        public void GivenINavigateToTheFacebookLoginPage()
        {
  
        }

        [Then(@"I close the saved credentials pop up")]
        public void ThenICloseTheSavedCredentialsPopUp()
        {
            Popups.Cancelsavedcredentials();
        }

        [Then(@"I click on email field")]
        public void ThenIClickOnEmailField()
        {
            Popups.Selectusername();
        }     

        [Then(@"I enter my mailid")]
        public void ThenIEnterMyMailid()
        {
            LoginPage.EnterUsername("kallem.nikhil99@gmail.com");
        }

        [Then(@"I click on password field")]
        public void ThenIClickOnPasswordField()
        {
            Popups.Selectpassword();
        }

        [Then(@"I entered my password")]
        public void ThenIEnteredMyPassword()
        {
            LoginPage.EnterPassword("nicknikhil789");
        }

        [Then(@"i ckick on login button")]
        public void ThenICkickOnLoginButton()
        {
            LoginPage.Login();
        }

        //[Then(@"I should be logged in successfully")]
        //public void ThenIShouldBeLoggedInSuccessfully()
        //{
        //    var profileElement = drivers._driver.FindElement(By.Id("profile_name"));
        //    if (profileElement != null)
        //    {
        //        // This asserts that the user is logged in if the profile element is present
        //        Console.WriteLine("Successfully logged in.");
        //    }
        //    else
        //    {
        //        throw new Exception("Login failed.");
        //    }
        //}
    }
}
