using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinGateTask3.Pages
{
    public class CheckoutButtonPage : BasePage
    {
        private const string _pageAddress = "https://pay-sandbox.coingate.com/pay/test12345679";
        private IWebElement _checkoutButton => Driver.FindElement(By.CssSelector("#payment-content > form > div > div.panel.panel-default > div.panel-body > button"));
        private string _pageAddress2 = "https://pay-sandbox.coingate.com/invoice/<uniqueID>";

      

        public CheckoutButtonPage(IWebDriver webDriver) : base(webDriver) { }

        public CheckoutButtonPage NavigateToDefaultPage()
        {
            if (Driver.Url != _pageAddress)
            {
                Driver.Url = _pageAddress;
            }
            Driver.Url = _pageAddress;
            return this;
        }

        public CheckoutButtonPage ClickCheckoutButton()
        {
            if (_checkoutButton.Enabled)
            {
                _checkoutButton.Click();
            }
            return this;
        }

        /*kadangi _pageaddress2 (tinklapis, i kuri naviguoja paspaudus CheckoutButton yra su kintancia galune, 
        tai norejau uzfiksuoti tik tinklapio pradzia iki uniqueID (taip pavadinau kintancia URL galune) ir patikrinti, 
        ar kiekviena kart uzkrauna i ''invoice'' puslapi. Butu reikeje mazos konsultacijos sioje vietoje, nes padariau,  bet
        nemanau, kad teisingai: 
        */
        public CheckoutButtonPage AssertCheckoutButton()
        {
            Assert.AreEqual(_pageAddress2, _pageAddress2);
            return this;
        }
    }
}
