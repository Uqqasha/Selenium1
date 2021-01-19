using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    class Test1
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("D:\\Installation Files");
        }

        [Test]
        public void test()
        {
            //Navigate to google page
            driver.Navigate().GoToUrl("https://client-rsg.azurewebsites.net/");



            //Maximize the window
            driver.Manage().Window.Maximize();



            System.Threading.Thread.Sleep(2000);



            //Validate screen title is present
            var element = driver.FindElement(By.XPath("(//*[@class='text-center'])[1]"));
            Assert.IsTrue(element.Displayed);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
