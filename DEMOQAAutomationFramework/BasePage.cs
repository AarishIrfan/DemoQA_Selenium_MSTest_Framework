using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMOQAAutomationFramework
{
    public class BasePage 
    {
        public static IWebDriver driver;
        public static IWebDriver SeleniumInit()
        {
            driver = new ChromeDriver();
            return driver;
        }
    }
}

