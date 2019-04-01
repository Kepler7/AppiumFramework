using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumFrameWork.Utilities
{
    public class Base
    {
        public AppiumLocalService AppiumServiceContext;
        public AndroidDriver<AndroidElement> AndroidContext;
        public AppiumUtilities appiumUtilities => new AppiumUtilities(AppiumServiceContext, AndroidContext);

        public AndroidDriver<AndroidElement> StartAppiumServerForHybrid()
        {
            AppiumServiceContext = appiumUtilities.StartAppiumLocalService();
            AndroidContext = appiumUtilities.InitializeAndroidHybridApp();
            return AndroidContext;
        }
    }
}
