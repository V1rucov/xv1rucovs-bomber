using OpenQA.Selenium;

namespace xv1Bomb
{
    public interface IObserver {
        public string Link { get; set; }
        public void Handle(IWebDriver webDriver, string phoneNumber);
    }
}