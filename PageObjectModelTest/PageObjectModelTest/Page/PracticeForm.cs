using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using PageObjectModelTest.Driver;
using WebDriver = PageObjectModelTest.Driver.WebDriver;

namespace PageObjectModelTest.Page
{
    public class PracticeForm
    {
        private IWebDriver driver = WebDriver.Instance;
        internal readonly object Button;

        public IWebElement FirstName => driver.FindElement(By.Id("firstName"));
        public IWebElement LastName => driver.FindElement(By.Id("lastName"));
        public IWebElement Email => driver.FindElement(By.Id("userEmail"));
        public IWebElement Gender => driver.FindElement(By.Id("gender-radio-2"));
        public IWebElement PhoneNumber => driver.FindElement(By.Id("userNumber"));
        public IWebElement Subject => driver.FindElement(By.Id("subjectsContainer"));
        public IWebElement Hobbies => driver.FindElement(By.Id("hobbies-checkbox-2"));
        public IWebElement Submit => driver.FindElement(By.Id("submit"));

     

        public void EnterName(string name)
        {
            FirstName.SendKeys(name);
        }
        public void EnterLastName(string name)
        {
            LastName.SendKeys(name);
        }

        public void SelectGender(string gender)
        {
            Gender.SendKeys(gender);
        }

        public void EnterPhone(string number)
        {
            PhoneNumber.SendKeys(number);
        }
        public void EnterSubject(string subject)
        {
            Subject.SendKeys(subject);
        }
        public void EnterHobbies(string name)
        {
            Hobbies.Click();
        }
        public void ClickSubmit(string name)
        {
            Submit.Click();
        }
        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
        }


    }
}
