using BoDi;
using FacebookInBrowser.Utilities;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace FacebookInBrowser.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        private readonly IObjectContainer _container;
        private AppiumDriver<AndroidElement> driver;

        public Hooks1(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario("@launch")]
        public void BeforeScenarioWithTag()
        {
            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("platformName", "Android");
            appiumOptions.AddAdditionalCapability("deviceName", "Samsung s20");
            appiumOptions.AddAdditionalCapability("platformVersion", "13");
            appiumOptions.AddAdditionalCapability("udid", "RF8N21BZZ4A");
            //appiumOptions.AddAdditionalCapability("app", "C:\\Users\\iray3\\Desktop\\apk\\dk.resound.smart3d-Signed.apk");
            appiumOptions.AddAdditionalCapability("appPackage", "com.facebook.katana");
            appiumOptions.AddAdditionalCapability("appActivity", "com.facebook.katana.LoginActivity");

            var httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromSeconds(120);
            var commandExecutor = new HttpCommandExecutor(new Uri("http://localhost:4723/wd/hub"), TimeSpan.FromSeconds(180));
            driver = new AndroidDriver<AndroidElement>(commandExecutor, appiumOptions);
            _container.RegisterInstanceAs<AppiumDriver<AndroidElement>>(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            drivers._driver = driver;
        }
        [AfterScenario]
        public void AfterScenario()
        {
           
        }
    }
}
