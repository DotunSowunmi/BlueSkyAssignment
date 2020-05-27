using BlueSkyProject3.PageObjects;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace BlueSkyProject3.StepDefinitions
{
    [Binding]
    public class BlueSkyCitadelTestingFormSteps
    {
       
        AutomationTestingFormPage automationTestingFormPage;
        public BlueSkyCitadelTestingFormSteps()
        {
            automationTestingFormPage = new AutomationTestingFormPage();
        }

        [Then(@"the page Url is ""(.*)""")]
        public void ThenThePageUrlIs(string url)
        {
            Assert.AreEqual(url, automationTestingFormPage.GetPageURL); //NUnit

            url.Should().Be(automationTestingFormPage.GetPageURL); //FluentAssertion
            url.Should().Contain("BlueSky");
            automationTestingFormPage.GetPageURL.Should().Contain("Bluesky");

            automationTestingFormPage.GetPageURL.Should().Contain("https://blueskycitadel.com/automation.testing.form/");

        }


        [Given(@"I navigate to the Bluesky Testing form")]
        public void GivenINavigateToTheBlueskyTestingForm()
        {
            automationTestingFormPage.NavigateToForm();
        }

      
        [When(@"I enter the single Line Text")]
        public void WhenIEnterTheSingleLineText()
        {
            automationTestingFormPage.EnterSingleLineText();
        }


        [When(@"I select One in the select box")]
        public void WhenISelectOneInTheSelectBox()
        {
            automationTestingFormPage.SelectOneFromSelectOneTwoThree(); 
        }
        
        [When(@"I enter Email")]
        public void WhenIEnterEmail()
        {
            automationTestingFormPage.EnterEmail(); 
        }
        
        [When(@"I select the Multi-select")]
        public void WhenISelectTheMulti_Select()
        {
            automationTestingFormPage.SelectMultiSelector(); 
        }
        
        [When(@"I select the Radio List")]
        public void WhenISelectTheRadioList()
        {
            automationTestingFormPage.SelectThreeFromSelectRadio();
        }
        
        [When(@"I select the Checkbox List")]
        public void WhenISelectTheCheckboxList()
        {
            automationTestingFormPage.SelectCheckBoxList();
        }
        
        [When(@"I select United Kingdom as Country")]
        public void WhenISelectUnitedKingdomAsCountry()
        {
            automationTestingFormPage.SelectUnitedKingdom();
        }
        
        [When(@"I select date from current month")]
        public void WhenISelectThOfTheCurrentMonth()
        {
            automationTestingFormPage.SelectDateFromCalender();
        }
        
        [When(@"I click on the Submit button")]
        public void WhenIClickOnTheSubmitButton()
        {
            automationTestingFormPage.ClickOnSubmit();
        }

        [Then(@"the message ""(.*)""")]
        public void ThenTheMessage(string successfulMessage)
        {
            Assert.AreEqual(successfulMessage, automationTestingFormPage.GetTextForSuccessfulMessage());
        }

        [Then(@"the error message ""(.*)""")]
        public void ThenTheErrorMessage(string errorMessage)
        {
            automationTestingFormPage.CheckErrorMessageIsDisplayed();

            Assert.AreEqual(errorMessage, automationTestingFormPage.GetTextForError());
        }

    }
}
