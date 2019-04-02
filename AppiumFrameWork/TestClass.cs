using AppiumFrameWork.Hooks;
using AppiumFrameWork.Pages;
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
            HomeClass home = new HomeClass(AndroidContext);
            home.ClickOnChats();
            
        }

    }
}
