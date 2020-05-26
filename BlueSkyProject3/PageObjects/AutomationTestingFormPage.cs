using BlueSkyProject3.Hooks;
using BlueSkyProject3.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BlueSkyProject3.PageObjects
{
   
    class AutomationTestingFormPage
    {
        IWebDriver driver;

        Waits waits = new Waits();
        IWebElement SingleLineText => driver.FindElement(By.XPath("//input[@id='nf-field-135']"));

        IWebElement SelectOneTwoThree => driver.FindElement(By.XPath("//*[@id='nf-field-136']"));

        IWebElement emailAdress => driver.FindElement(By.CssSelector("#nf-field-124"));

        IWebElement Multiselect123 => driver.FindElement(By.CssSelector("#nf-field-137"));

        IWebElement SelectRadio => driver.FindElement(By.Id("nf-label-class-field-138-0"));

        IWebElement selectCheckBoxList123 => driver.FindElement(By.CssSelector("#nf-label-field-139-0"));

        IWebElement selectCountry => driver.FindElement(By.Id("nf-field-140"));

        IWebElement datefromCalender => driver.FindElement(By.CssSelector("input.pikaday__display.pikaday__display--pikaday.ninja-forms-field.nf-element.datepicker"));

        IWebElement passwordText => driver.FindElement(By.Id("nf-field-144"));

        IWebElement submit => driver.FindElement(By.Id("nf-field-133"));

        IWebElement errorMsg => driver.FindElement(By.CssSelector("#nf-form-errors-9 > nf-errors > nf-section > div"));
        IWebElement successfulMessage => driver.FindElement(By.XPath("//p[contains(text(),'Your form has been successfully submitted.')]"));

        public string GetPageTitle => driver.Title;
        public string GetPageURL => driver.Url;
        public string GetTextForSuccessfulMessage()
        {
            Thread.Sleep(500);
            return successfulMessage.Text;
        }
        

        //public string GetPageTitle()

        //{
        //    return driver.Title;
        //}

        public void CheckErrorMessageIsDisplayed()

        {
            Assert.IsTrue(errorMsg.Displayed);
        }

        public string GetTextForError()

        {
            IWebDriver myDriver = driver;
            return waits.MyDriverWait(driver, errorMsg).Text;
        }
        public void EnterPassword(string password)
        {
            passwordText.SendKeys(password);
        }

        internal void EnterEmail(string email)
        {
            emailAdress.SendKeys(email);
        }


        public void SelectDateFromCalender() 
        {
            datefromCalender.SendKeys("02/12/2020");
            datefromCalender.SendKeys(Keys.Tab);
            Thread.Sleep(5000);
        }

        public void SelectCheckBoxList()
        {
            SelectElement checkBoxList = new SelectElement(selectCheckBoxList123);
            checkBoxList.SelectByText("One");
            //selectCheckBoxList123.Click();
        }

        public void SelectThreeFromSelectRadio()

        {
            SelectRadio.Click();
        }

        public void ClickOnSubmit()

        {
            submit.Click();
        }
        public void SelectUnitedKingdom()
        {
            SelectElement selectcountry = new SelectElement(selectCountry);
            selectcountry.SelectByText("United Kingdom");

        }
        public void SelectMultiSelector()
        {
            SelectElement multiSeletor = new SelectElement(Multiselect123);
            multiSeletor.SelectByValue("two");
            multiSeletor.SelectByValue("three");
        }

        public void SelectOneFromSelectOneTwoThree()
        {
            SelectElement select = new SelectElement(SelectOneTwoThree);
            select.SelectByValue("one");
        }
        public void EnterEmail()
        {
            emailAdress.SendKeys("dotun@sowunmi.net");
        }


        public void EnterSingleLineText()
        {
            SingleLineText.SendKeys("Dotun");
        }
        public AutomationTestingFormPage()
        {
            driver = Hook.driver;
            Waits wait = new Waits();
        }

        public void NavigateToForm()
        {
            driver.Navigate().GoToUrl("https://blueskycitadel.com/automation.testing.form/");
        }


        public void NavigateToFormwithParameter(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

    }
}