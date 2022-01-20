using OpenQA.Selenium;

namespace xv1Bomb.WebSites
{
    public class goldapple : IObserver {
        public string Link { get; set; }

        public goldapple() {
            Link = @"https://goldapple.ru/";
        }

        public void Handle(IWebDriver webDriver, string phoneNumber) {
            webDriver.FindElement(By.XPath("//button[@class='button-primary modal-city-informer__btn modal-city-informer__btn_primary']")).Click();
            webDriver.FindElement(By.XPath("//button[@class='header-tab-button header-tab-button_customer']")).Click();
            webDriver.FindElement(By.XPath("//input[@name='phone']")).SendKeys(phoneNumber);
            webDriver.FindElement(By.XPath("//button[@class='button-primary' and @type='submit' ]")).Click();
        }
    }
}