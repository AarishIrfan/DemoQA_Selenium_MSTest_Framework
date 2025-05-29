using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMOQAAutomationFramework
{
    public class Login : ExtentReport
    {
        //LOCATORS
        By UserName = By.Id("userName");
        By Password = By.Id("password");
        By LoginBtn = By.Id("login");

        public void LoginUser(string url,string username,string pass)
        {
            LogReport("LoginTestCase001");
            exParentTest = extentReports.CreateTest("LoginTestCase001");
            exChildTest = ExtentReport.exParentTest.CreateNode("Login");

            driver.Url = url;
            TakeScreenshot(driver, Status.Pass, "url open");
            driver.FindElement(UserName).SendKeys(username);
            TakeScreenshot(driver, Status.Pass, "Username");
            driver.FindElement(Password).SendKeys(pass);
            TakeScreenshot(driver, Status.Pass, "Password");
            driver.FindElement(LoginBtn).Click();
            TakeScreenshot(driver, Status.Pass, "Login Button");

        }
    }
}
