using OpenQA.Selenium;

namespace xv1Bomb.WebSites
{
    public class bapteka : IObserver {
        public string Link { get; set; }

        public bapteka() {
            Link = @"https://b-apteka.ru/lk/login";
        }

        public void Handle(IWebDriver webDriver, string phoneNumber) {
            webDriver.FindElement(By.XPath("//button[text()='Да']")).Click();
            webDriver.FindElement(By.XPath("//input[@name='phone']")).SendKeys(phoneNumber);
            webDriver.FindElement(By.XPath("//button[@class='button button_block button_xl button_default user-confirm-phone__send-sms j-user-confirm-phone-send-sms']")).Click();
        }
    }
}