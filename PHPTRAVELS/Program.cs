using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace PHPTRAVELS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            Thread.Sleep(2000);

            driver.Navigate().GoToUrl("https://phptravels.com/demo");
            Thread.Sleep(2000);

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//a[contains(@href,'login')]")).Click();
            Thread.Sleep(2000);

            //String CurrentWindows = driver.WindowHandles;

            string p = driver.WindowHandles[0];
            string c = driver.WindowHandles[1];
            driver.SwitchTo().Window(c);

            Thread.Sleep(2000);
             driver.FindElement(By.XPath("//input[@name='email' and @type='email']")).SendKeys("user@phptravels.com");

            Thread.Sleep(2000);
             driver.FindElement(By.XPath("//input[@name='password' and @type='password']")).SendKeys("demouser");

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//span[text()='Login']")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[@href='https://www.phptravels.net/']")).Click();

            Thread.Sleep(2000);
             driver.FindElement(By.XPath("//*[@id='select2-hotels_city-container']")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("select2-search__field")).SendKeys("kolkata");

            Thread.Sleep(5000);

            //After sending kolkata to the search box, just hit ENTER
             WebElement textbox = (WebElement)driver.FindElement(By.ClassName("select2-search__field"));
             textbox.SendKeys(Keys.Enter);

            Thread.Sleep(2000);
            //driver.FindElement(By.XPath("//*[@id='checkin']")).Click();


            //WebElement textbox1 = (WebElement)driver.FindElement(By.ClassName("select2-search__field"));
            //textbox.SendKeys(Keys.Enter);

            driver.FindElement(By.XPath("//*[@id='submit']")).Click();
            Thread.Sleep(2000);

            IWebElement searchBox = driver.FindElement(By.XPath("//input[@type='text' and @class='form-control' and @placeholder='Hotel name.']"));
            searchBox.Click();
            searchBox.SendKeys("Aafreen Tower");
            Thread.Sleep(2000);

            IWebElement detailsBTN = driver.FindElement(By.XPath("//*[@id='collection o 82694 aafreen tower']/div/div[2]/div/div[2]/div/a"));
            detailsBTN.Click();

            //js.ExecuteScript("window.scrollBy(0,500)");
            //Thread.Sleep(2000);



            Thread.Sleep(120000);


            driver.Close();
            driver.Quit();
        }
    }
}
