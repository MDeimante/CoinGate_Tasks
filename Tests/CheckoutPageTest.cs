using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinGateTask3.Tests
{
    public class CheckoutPageTest : BaseTest

        //Cia pabandziau padaryti viena test case'a - mokejimas su bitcoinais, be lightening, ivedus teisinga el. pasto adresa.
        //Norimas rezultatas - matomas QR kodas paspaudus apmokejimo mygtuka. 
        //Cia turetu buti validuotas kiekvienas mygtukas ir email laukas pries tai, o tuomet jau rasyti daug test case'u atskirai su kiekviena
        // valiuta. As, deja, neturiu jokios patirties ir medziagos, kaip dirbit su laikinais elementais ir URL, todel sia uzduoti
        //galiu tik aprasyti, taciau esu tikra, kad su minimanlia pagalba tokios ir panasios uzduotys tikrai butu iveikiamos.

     [Test]
     public static void PayWithBitcoins()
        {
            _checkoutPage.NavigateToDefaultPage();
            _checkoutPage.ClickBitcoinButton();
            _checkoutPage.AssertPayment();
        }

    }
}
