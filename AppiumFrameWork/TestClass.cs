using AppiumFrameWork.Hooks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppiumFrameWork
{
    [TestFixture]
    public class TestClass : TestInitialize
    {
        [Test]
        public void OpenAppium()
        {





            //WebDriverWait driverWait = new WebDriverWait(androidDriver, TimeSpan.FromSeconds(10));
            //driverWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("icon ion-ios-chatboxes-outline")));
            AndroidContext.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            AndroidContext.FindElementByXPath("//i[@class='icon ion-ios-chatboxes-outline']").Click();

            
        }

    }
}
