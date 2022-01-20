using OpenQA.Selenium;

namespace xv1Bomb.WebSites
{
    public class kari : IObserver {
        public string Link { get; set; }

        public kari() {
            Link = @"https://kari.com/auth/sms/";
        }

        public void Handle(IWebDriver webDriver, string phoneNumber) {
            webDriver.FindElement(By.XPath("//input[@name='phone']")).SendKeys(phoneNumber);
            webDriver.FindElement(By.XPath("//button[@class='css-uvo8co e1eob9z01']")).Click();
        }
    }
}