using AventStack.ExtentReports.Reporter.Configuration;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace DEMOQAAutomationFramework
{
    public class ExtentReport
    {
        public static IWebDriver driver;
        public static ExtentReports extentReports;
        public static ExtentTest exParentTest;
        public static ExtentTest exChildTest;
        public static string dirpath;
        public static IWebDriver SeleniumInit(string browser)
        {
            if (browser == "Chrome")
            {
                var ChromeOptions = new ChromeOptions();
                ChromeOptions.AddArguments("- - start-maximixed");
                ChromeOptions.AddArguments("- - incognito");
                IWebDriver chromeDriver = new ChromeDriver();
                driver = chromeDriver;
            }
            else if (browser == "Firefox")
            {
                FirefoxOptions options = new FirefoxOptions();
                options.AddArguments("");
                driver = new FirefoxDriver(options);
            }
            return driver;
        }
        public static void LogReport(string testcase)
        {
            extentReports = new ExtentReports();
            dirpath = @"..\..\TestExecutionReports\" + '_' + testcase;

            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(dirpath);

            htmlReporter.Config.Theme = Theme.Standard;

            extentReports.AttachReporter(htmlReporter);
        }

        public static void TakeScreenshot(IWebDriver driver, Status status, string stepDetail)
        {
            string path = @"C:\TestExecutionReports\" + "TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            Screenshot image_username = ((ITakesScreenshot)driver).GetScreenshot();
            image_username.SaveAsFile(path + ".png", ScreenshotImageFormat.Png);
            ExtentReport.exChildTest.Log(status, stepDetail, MediaEntityBuilder
                .CreateScreenCaptureFromPath(path + ".png").Build());
        }


    }
}
