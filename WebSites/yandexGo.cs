using OpenQA.Selenium;

namespace xv1Bomb.WebSites
{
    public class yandexGo : IObserver {
        public string Link { get; set; }

        public yandexGo() {
            Link = @"https://passport.yandex.ru/auth?retpath=https%3A%2F%2Ftaxi.yandex.ru%2F&from=taxi ";
        }

        public void Handle(IWebDriver webDriver, string phoneNumber) {
            webDriver.FindElement(By.XPath("//input[@placeholder='Телефон или почта']")).SendKeys(phoneNumber);
            webDriver.FindElement(By.XPath("//button[@id='passp:sign-in']")).Click();
        }
    }
}