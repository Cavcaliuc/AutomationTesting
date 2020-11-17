using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTesting 

{
    [TestClass]
    public class MS_Test_Cross_Browser_Test
    {
        String test_url = "https://www.ebay.com/";

        [TestMethod]
        public void NavigateToDoApp()
        {
            IWebDriver driver;

            // Local Selenium WebDriver
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl(test_url);

            driver.Manage().Window.Maximize();

            // Click on Search box
            IWebElement searchBox = driver.FindElement(By.CssSelector("div[id='gh-ac-box2'] input"));
            searchBox.Click();
            // Write something
            searchBox.SendKeys("Computer");
            searchBox.SendKeys(Keys.Enter);

            IWebElement header = driver.FindElement(By.CssSelector("header[id='gh']"));

            Console.WriteLine("\n-------------------------\n");
            Console.WriteLine("TEST PASSED");
            Console.WriteLine("\n-------------------------\n");

            driver.Quit();
        }
    }
}

