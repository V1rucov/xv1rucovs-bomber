using OpenQA.Selenium;

namespace xv1Bomb.WebSites
{
    public class cenalom : IObserver {
        public string Link { get; set; }

        public cenalom() {
            Link = @"https://cenalom.ru/reg";
        }

        public void Handle(IWebDriver webDriver, string phoneNumber) {
            webDriver.FindElement(By.XPath("//input[@name='phone']")).SendKeys(phoneNumber);
            webDriver.FindElement(By.XPath("//input[@class='btn btn-std g-recaptcha']")).Click();
        }
    }
}