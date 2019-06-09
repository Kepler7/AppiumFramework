using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumFrameWork.Pages
{
    public class ChatsPage
    {

        #region Constructor
        private AndroidDriver<AndroidElement> _androidDriver;

        public ChatsPage(AndroidDriver<AndroidElement> androidDriver)
        {
            _androidDriver = androidDriver;
        }

        #endregion

    }
}
