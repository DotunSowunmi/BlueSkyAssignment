using BlueSkyProject3.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkyProject3.PageObjects
{
    class DataTablePage
    {
        IWebDriver driver;

        IWebElement emailAdress => driver.FindElement(By.Name("email"));

        IWebElement passwordText => driver.FindElement(By.Id("nf-field-144"));

        public DataTablePage()
        {
            driver = Hook.driver;
        }

        public void EnterEmailAndPassword(string email, string password)
        {
            emailAdress.SendKeys(email);
            passwordText.SendKeys(password);
        }
    }
}
