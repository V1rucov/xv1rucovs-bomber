using OpenQA.Selenium;

namespace xv1Bomb.WebSites
{
    public class posudaMart : IObserver
    {
        public string Link { get; set; }

        public posudaMart() {
            Link = @"https://posudamart.ru/account/login";
        }

        public void Handle(IWebDriver webDriver, string phoneNumber) {
            webDriver.FindElement(By.XPath("//input[@name='phone']")).SendKeys(phoneNumber);
            webDriver.FindElement(By.XPath("//button[text()='Получить код']")).Click();
        }
    }
}