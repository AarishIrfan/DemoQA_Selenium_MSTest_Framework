using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMOQAAutomationFramework
{
    public class QAPracticeForm : BasePage
    {
        //LOCATORS

        By fName = By.Id("firstName");
        By LName = By.Id("lastName");
        By Email = By.Id("userEmail");
        By SelectGender = By.CssSelector("#genterWrapper > div.col-md-9.col-sm-12 > div:nth-child(1) > label");
        By UserNumber = By.Id("userNumber");
        By DateOfBirthInput = By.Id("dateOfBirthInput");
        By selectsubject = By.Id("subjectsInput");
        By hobbiescheckbox = By.CssSelector("label[for= 'hobbies-checkbox-2']");
        By UploadPicture = By.Id("uploadPicture");
        By HomeAddress = By.Id("currentAddress");
        By SelectState = By.Id("react-select-3-input");
        By SelectCity = By.Id("react-select-4-input");
        By SubmitBtn = By.Id("submit");

        public void PracticeForm(string url,string FirstName,string LastName, string EmailAddress, string Number, string Birthdate ,string subjects,  string Picture, string Address,string state,string city)
        {
            driver.Url = url;
            driver.FindElement(fName).SendKeys(FirstName);
            driver.FindElement(LName).SendKeys(LastName);
            driver.FindElement(Email).SendKeys(EmailAddress);
            driver.FindElement(SelectGender).Click();
            driver.FindElement(UserNumber).SendKeys(Number);
            driver.FindElement(UserNumber).SendKeys(Keys.Tab);
            driver.FindElement(DateOfBirthInput).SendKeys(Birthdate);
            driver.FindElement(DateOfBirthInput).SendKeys(Keys.Enter);
           

            driver.FindElement(selectsubject).SendKeys(Keys.Tab);
            driver.FindElement(selectsubject).SendKeys(subjects);
            driver.FindElement(selectsubject).SendKeys(Keys.Enter);
            driver.FindElement(hobbiescheckbox).Click(); 
            driver.FindElement(UploadPicture).SendKeys(Picture);
            driver.FindElement(HomeAddress).SendKeys(Address);

            
            driver.FindElement(SelectState).SendKeys(state);
            driver.FindElement(SelectState).SendKeys(Keys.Enter);


            driver.FindElement(SelectCity).SendKeys(city);
            driver.FindElement(SelectCity).SendKeys(Keys.Enter);
            driver.FindElement(SubmitBtn).Click();  
        }
    }
}
