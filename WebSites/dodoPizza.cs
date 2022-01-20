using OpenQA.Selenium;

namespace xv1Bomb.WebSites
{
    public class dodoPizza : IObserver {
        public string Link { get; set; }

        public dodoPizza() {
            Link = @"https://dodopizza.ru/";
        }

        public void Handle(IWebDriver webDriver, string phoneNumber) {
            webDriver.FindElement(By.XPath("//a[text()='Абакан']")).Click();
            webDriver.FindElement(By.XPath("//button[@class='sc-91ilwk-0 ceAbTC']")).Click();
            webDriver.FindElement(By.XPath("//input[@id='phn-input']")).SendKeys(phoneNumber);
            webDriver.FindElement(By.XPath("//button[@class='sc-91ilwk-0 ceAbTC submit-button']")).Click();
        }
    }
}