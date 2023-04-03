using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace AppCon
{
    internal class Program
    {
        static void Pause()
        {
            System.Threading.Thread.Sleep(5000);
        }
        static void Main(string[] args)
        {
            using(IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://www.google.com/");
                
                IWebElement i =  driver.FindElement(By.Name("q"));
                if(i!=null)
                {
                    i.SendKeys("לוגיסטים סלע אשדוד");
                    i.SendKeys(System.Environment.NewLine);

                    Pause();

                    var l = driver.FindElement(By.PartialLinkText(""));
                        l.Click();


                }
            }
        }
    }
}
