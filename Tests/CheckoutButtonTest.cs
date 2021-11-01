using CoinGateTask3.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinGateTask3.Tests
{
    public class CheckoutButtonTest : BaseTest
    {
        [Test]
        public static void AssertCheckoutButton()
        {
            _checkoutButtonPage.NavigateToDefaultPage();
            _checkoutButtonPage.ClickCheckoutButton();
            _checkoutButtonPage.AssertCheckoutButton();
        }
    }
}
