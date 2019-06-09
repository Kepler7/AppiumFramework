using AppiumFrameWork.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumFrameWork.Pages
{
    public class HomeClass : Base
    {
        #region Locators
        //private readonly By chatss = By.XPath("//i[@class='icon ion-ios-chatboxes-outline']");

        [FindsBy(How = How.XPath, Using = "//i[@class='icon ion-ios-chatboxes-outline']")]
        IWebElement chats { get; set; }

        #endregion
        #region Constructor
        AndroidDriver<AndroidElement> _androidDriver;

        public HomeClass(AndroidDriver<AndroidElement> androidDriver)
        {
            PageFactory.InitElements(androidDriver, this);
            _androidDriver = androidDriver;
        }

        #endregion

        public ChatsPage ClickOnChats()
        {
            chats.Click();
            return new ChatsPage(_androidDriver);
        }

        #region public methods

      

        #endregion
    }
}
