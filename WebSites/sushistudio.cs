using OpenQA.Selenium;

namespace xv1Bomb.WebSites
{
    public class sushistudio : IObserver {
        public string Link { get; set; }

        public sushistudio() {
            Link = @"https://passport.yandex.ru/auth?backpath=https%3A%2F%2Feda.yandex.ru%2Fmoscow%3FregionSlug%3Dmoscow%26shippingType%3Ddelivery&origin=eats_desktop&retpath=https%3A%2F%2Feda.yandex.ru%2Fmoscow%3Fauth_from%3Dside_menu%26regionSlug%3Dmoscow%26shippingType%3Ddelivery";
        }

        public void Handle(IWebDriver webDriver, string phoneNumber) {
            webDriver.FindElement(By.XPath("//input[@class='Textinput-Control']")).SendKeys(phoneNumber);
            webDriver.FindElement(By.XPath("//button[@class='Button2 Button2_size_l Button2_view_action Button2_width_max Button2_type_submit']")).Click();
        }
    }
}