using DEMOQAAutomationFramework.LoginPage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DEMOQAAutomationFramework
{
    [TestClass]
    public class ExecutionPage : ExtentReport
    {
       
    
        [TestMethod]
        public void RegistrationTestCase0001()
        {
          
            RegistrationPage RegPage = new RegistrationPage();
            RegPage.RegisterUser("https://demoqa.com/register", "Aarish", "Irfan", "AarishWorks", "aarish");
      
        }
        [TestMethod]
        public void LoginTestCase001()
        {
            
            Login login = new Login();
            login.LoginUser("https://demoqa.com/login","AarishWorks", "aarish");
            extentReports.Flush();
            driver.Close();
            
        }
        [TestMethod]
        public void PracticeFormTestCase001()
        {
            //BasePage.SeleniumInit();
            QAPracticeForm Form = new QAPracticeForm();
            Form.PracticeForm("https://demoqa.com/automation-practice-form", "Aarish", "Irfan", "aarishirfancs@gmail.com", "03330263194","03 July 1998", "Computer Science", "E:\\Pictures\\3628 .JPG", "PECHS BLOCK-6", "NCR", "Delhi");
            //BasePage.driver.Close();
        }
    }
}
