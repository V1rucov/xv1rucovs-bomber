using OpenQA.Selenium;

namespace xv1Bomb.WebSites
{
    public class burgerking : IObserver {
        public string Link { get; set; }

        public burgerking() {
            Link = @"https://burgerking.ru/";
        }

        public void Handle(IWebDriver webDriver, string phoneNumber) {
            webDriver.FindElement(By.XPath("//div[@class='bk-receive-types__look-button']")).Click();
            webDriver.FindElement(By.XPath("//div[@class='bk-auth__not-user']")).Click();
            webDriver.FindElement(By.XPath("//input[@class='bk-input__element']")).SendKeys(phoneNumber);
            webDriver.FindElement(By.XPath("//input[@class='bk-checkbox-input__element']")).Click();
            webDriver.FindElement(By.XPath("//div[@class='bk-phone__button']")).Click();
        }
    }
}