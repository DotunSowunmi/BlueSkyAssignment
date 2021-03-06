﻿using BlueSkyProject3.PageObjects;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;


namespace BlueSkyProject3.StepDefinitions
{
    [Binding]
    public class DataDrivenWithTableSteps
    {
        DataTablePage dataTablePage;


        public DataDrivenWithTableSteps()
        {
            dataTablePage = new DataTablePage();
        }

        [When(@"I enter my email and password")]
        public void WhenIEnterMyEmailAndPassword(Table table)
        {
            var emailandPassword = table.CreateInstance<Details>();
            string email = emailandPassword.Email;
            string password = emailandPassword.Password;


            dataTablePage.EnterEmailAndPassword(email, password);
        }
    }
}
