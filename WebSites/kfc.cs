using System.Threading;
using OpenQA.Selenium;

namespace xv1Bomb.WebSites
{
    public class kfc : IObserver {
        public string Link { get; set; }

        public kfc() {
            Link = @"https://www.kfc.ru/login";
        }

        public void Handle(IWebDriver webDriver, string phoneNumber) {
            webDriver.FindElement(By.XPath("//input[@class='_1cE6wpVzEG']")).SendKeys(phoneNumber);
            Thread.Sleep(340);
            webDriver.FindElement(By.XPath("//div[@class='MLbt8FrkM1']")).Click();
            Thread.Sleep(406);
            webDriver.FindElement(By.XPath("//button[@class='button-m-primary']")).Click();
        }
    }
}