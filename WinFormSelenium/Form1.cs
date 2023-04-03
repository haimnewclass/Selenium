using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WinFormSelenium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Pause(int mili = 10000)
        {
            System.Threading.Thread.Sleep(mili);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://zionet-selenium.bubbleapps.io/version-test";
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(url);
                Pause();
                IWebElement  aTag =  driver.FindElement(By.Id("rJUDFxBO112"));


                if (aTag != null)
                {
                    aTag.Click();
                    aTag.SendKeys("blalbla");
                    
                }

            }
        }
    }
}