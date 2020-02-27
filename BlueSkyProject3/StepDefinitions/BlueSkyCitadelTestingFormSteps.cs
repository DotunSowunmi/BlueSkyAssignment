using BlueSkyProject3.PageObjects;
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
            Thread.Sleep(5000);
            automationTestingFormPage.ClickSubmitButton();

        }

        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            automationTestingFormPage.EnterPassword();
        }


        [Then(@"the message ""(.*)""")]
        public void ThenTheMessage()
        {
            
        }
    }
}
