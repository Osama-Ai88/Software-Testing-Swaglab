using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Final_Project
{
    class TestSetup
    {
        public static IWebDriver driver = new ChromeDriver();
        public static string url = "https://www.saucedemo.com/";



        public static void NavigateToUrl(IWebDriver driver, string url) // driver = chrome , url = https://www.saucedemo.com/
        {
            driver.Manage().Window.Size = new Size(1500, 900);
            driver.Navigate().GoToUrl(url);
            
        }

        public static void HighlightElement(IWebDriver driver, IWebElement element)
        {

            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].setAttribute('style' , 'background: lightpink !important')", element);
                                                                            
            System.Threading.Thread.Sleep(1000);
            executor.ExecuteScript("arguments[0].setAttribute('style' , 'border: solid 1px white !important')", element);
        }
    }
}
