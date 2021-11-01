using CoinGateTask3.Drivers;
using CoinGateTask3.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinGateTask3.Tests
{
    public class BaseTest
    {
        protected static IWebDriver Driver;
        public static CheckoutButtonPage _checkoutButtonPage;
        public static CheckoutPage _checkoutPage;
        


        [OneTimeSetUp]
        public static void SetUp()
        {
            Driver = CustomDriver.GetChromeDriver();
            _checkoutButtonPage = new CheckoutButtonPage(Driver);
            //_checkoutPage = new CheckoutPage(Driver);
        }

        /*[TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Outcome != ResultState.Success) //?????????????????????
            {
                Screenshot ss = ((ITakesScreenshot)Driver).GetScreenshot();
                ss.SaveAsFile("C://Image.png",
                ScreenshotImageFormat.Png);
            
        }*/
    }
}
