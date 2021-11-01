using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinGateTask3.Pages
{
    public class CheckoutPage : BasePage
    {
        private const string _pageAddress3 = "https://pay-sandbox.coingate.com/invoice/80a14380-a4a9-46cf-84e2-6845e332f467";
        private IWebElement _signInButton => Driver.FindElement(By.CssSelector("#sign-in-banner > div > span.ant-alert-message > span > a:nth-child(1)"));
        private IWebElement _signUpButton => Driver.FindElement(By.CssSelector("#sign-in-banner > div > span.ant-alert-message > span > a:nth-child(2)"));
        private IWebElement _forwardInvoiceButton => Driver.FindElement(By.ClassName("ant-btn ant-dropdown-trigger ant-btn-sm ant-btn-icon-only"));
        private IWebElement _bitcoinButton => Driver.FindElement(By.CssSelector("#payment-new > div:nth-child(2) > div > div > div.currency-card.active > div.currency-card-main-div > div:nth-child(1) > img"));
        private IWebElement _lighteningNwetworkSwitchButtonBitcoin => Driver.FindElement(By.Id("bitcoin-ln-switch"));
        private IWebElement _whatsThisButton1 => Driver.FindElement(By.CssSelector("#payment-new > div:nth-child(2) > div > div > div.currency-card.active > div.currency-card-additional-div.lightning-network > div:nth-child(2) > a"));
        private IWebElement _rippleButton => Driver.FindElement(By.CssSelector("#payment-new > div:nth-child(2) > div > div > div.currency-card.active > div > div:nth-child(1) > img"));
        private IWebElement _ethereumButton => Driver.FindElement(By.CssSelector("#payment-new > div:nth-child(2) > div > div > div:nth-child(3) > div > div:nth-child(1) > img"));
        private IWebElement _liteCoinButton => Driver.FindElement(By.CssSelector("#payment-new > div:nth-child(2) > div > div > div.currency-card.active > div.currency-card-main-div > div:nth-child(1) > img"));
        private IWebElement _lighteningNetworkSwitchButtonLitecoin => Driver.FindElement(By.Id("litecoin-ln-switch"));
        private IWebElement _whatsThisButton2 => Driver.FindElement(By.CssSelector("#payment-new > div:nth-child(2) > div > div > div:nth-child(4) > div.currency-card-additional-div.lightning-network > div:nth-child(2) > a"));
        private IWebElement _moreCurrenciesButton => Driver.FindElement(By.CssSelector("#payment-new > div:nth-child(2) > div > div > div.ant-collapse.ant-collapse-icon-position-left > div > div.ant-collapse-header > i > svg"));
        private IWebElement _bitcoinCashButton => Driver.FindElement(By.CssSelector("#payment-new > div:nth-child(2) > div > div > div.ant-collapse.ant-collapse-icon-position-left > div > div.ant-collapse-content.ant-collapse-content-active > div > div > div > div:nth-child(1) > img"));
        private IWebElement _emailInputField => Driver.FindElement(By.Id("#invoice-email"));
        private IWebElement _questionMark => Driver.FindElement(By.CssSelector("#payment-new > div:nth-child(3) > div > div > div > div > span > span > span.ant-input-suffix > i > svg"));
        private IWebElement _payWithSelectedCurrencyButton => Driver.FindElement(By.Id("invoice-checkout-button"));
        private IWebElement _cancelOrderButton => Driver.FindElement(By.CssSelector("#invoice > div.mt-10.buttons > div > div.pull-left > span > button"));
        private IWebElement _howToPayButton => Driver.FindElement(By.CssSelector("#invoice > div.footer > div:nth-child(1) > div > a:nth-child(1)"));
        private IWebElement _faqButton => Driver.FindElement(By.CssSelector("#invoice > div.footer > div:nth-child(1) > div > button"));
        private IWebElement _creditcardButton => Driver.FindElement(By.CssSelector("#invoice > div.footer > div:nth-child(1) > div > a:nth-child(3)"));
        private IWebElement _invoiceQRcode => Driver.FindElement(By.Id("invoice - qr - code"));
        public CheckoutPage(IWebDriver webDriver) : base(webDriver) { }

        public CheckoutPage NavigateToDefaultPage()
        {
            if (Driver.Url != _pageAddress3)
            {
                Driver.Url = _pageAddress3;
            }
            Driver.Url = _pageAddress3;
            return this;
        }

        public CheckoutPage ClickBitcoinButton()
        {
            if (_bitcoinButton.Enabled)
            {
                _bitcoinButton.Click();
            }
            return this;
        }

        public CheckoutPage InputEmail()
        {
            _emailInputField.Click();
            _emailInputField.Clear();
            _emailInputField.SendKeys("deimante.mikenaite@yahoo.com");

            return this;
        }

        public CheckoutPage PayWithBitcoin()
        {
            if (_payWithSelectedCurrencyButton.Enabled)
            
            _payWithSelectedCurrencyButton.Click();
           
            return this;
        }

        public CheckoutPage AssertPayment()
        {
            Assert.AreEqual(true, _invoiceQRcode.Displayed);
            return this;
        }

    } 
}
