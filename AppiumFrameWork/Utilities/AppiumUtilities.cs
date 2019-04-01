using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumFrameWork.Utilities
{
    public class AppiumUtilities : Base
    {
        private AppiumLocalService _appiumLocalService;
        private readonly AndroidDriver<AndroidElement> _androidDriver;
        
        #region Constructor
        public AppiumUtilities(AppiumLocalService appiumLocalService, AndroidDriver<AndroidElement> androidDriver)
        {
            _appiumLocalService = appiumLocalService;
            _androidDriver = androidDriver;
        }
        #endregion

        private void StarAppiumLocalService()
        {
            if(!_appiumLocalService.IsRunning)
                _appiumLocalService.Start();
        }

        public AndroidDriver<AndroidElement> InitializeAndroidHybridApp()
        {
            DesiredCapabilities desiredCapabilities = new DesiredCapabilities();
            desiredCapabilities.SetCapability(MobileCapabilityType.PlatformName, "Android");
            desiredCapabilities.SetCapability(MobileCapabilityType.DeviceName, "Kep7");
            desiredCapabilities.SetCapability(MobileCapabilityType.App, @"C:\Users\deneb\Desktop\Appium C# Framework\android-debug.apk");
            desiredCapabilities.SetCapability("chromedriverExecutable", @"C:\Users\deneb\source\repos\AppiumFrameWork\drivers\chromedriver.exe");

            AndroidDriver<AndroidElement> androidDriver = new AndroidDriver<AndroidElement>(_appiumLocalService, desiredCapabilities);

            androidDriver.Context = androidDriver.Contexts.First(x => x.Contains("WEBVIEW_"));
            return androidDriver;
        }

        //code to use any free port when launch test case
        public AppiumLocalService StartAppiumLocalService()
        {
            _appiumLocalService = new AppiumServiceBuilder().UsingAnyFreePort().Build();
            StarAppiumLocalService();
            return _appiumLocalService;
        }

        public AppiumLocalService StartAppiumLocalService(int portNumber)
        {
            _appiumLocalService = new AppiumServiceBuilder().UsingPort(portNumber).Build();
            StarAppiumLocalService();
            return _appiumLocalService;
        }

        public void CloseAppiumServer()
        {
            _androidDriver.CloseApp();
        }

    }
}
