using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace SeleniumConsole
{
    internal class Program
    {
        static public void Pause()
        {
            System.Threading.Thread.Sleep(5000);
        }
        static void Main(string[] args)
        {
            string url = "https://www.google.com/";
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(url);
                Pause();

                driver.FindElement(By.Name("q")).SendKeys("nba");
                driver.FindElement(By.Name("q")).SendKeys(System.Environment.NewLine);
                Pause();
            }
        }
    }
}
