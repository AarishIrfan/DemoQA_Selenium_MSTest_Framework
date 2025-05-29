using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMOQAAutomationFramework.LoginPage
{
    public class RegistrationPage 
    {
        //LOCATORS//
        By FirstName = By.Id("firstname");
        By LastName = By.Id("lastname");
        By Username = By.Id("userName");
        By Password = By.Id("password");
        //By HumanCheckBtn = By.CssSelector("#recaptcha-anchor");
        By SubmitBtn = By.Id("register");

        public void RegisterUser (string url, string Firstname, string Lastname, string username, string password)
        {
           
            driver.Url = url;
            driver.FindElement(FirstName).SendKeys(Firstname);
            driver.FindElement(LastName).SendKeys(Lastname);
            driver.FindElement(Username).SendKeys(username);
            driver.FindElement(Password).SendKeys(password);
            //driver.FindElement(HumanCheckBtn).Click();
            driver.FindElement(SubmitBtn).Click();
        }
    }
}
