using System.Threading;
using OpenQA.Selenium;

namespace xv1Bomb.WebSites
{
    public class kdvonline : IObserver {
        public string Link { get; set; }

        public kdvonline() {
            Link = @"https://kdvonline.ru/signin";
        }

        public void Handle(IWebDriver webDriver, string phoneNumber) {
            webDriver.FindElement(By.XPath("//input[@name='phone']")).SendKeys(phoneNumber);
            webDriver.FindElement(By.XPath("//button[@class='gBpUnJsuz aAos5597A bAos5597A jAos5597A']")).Click();
        }
    }
}