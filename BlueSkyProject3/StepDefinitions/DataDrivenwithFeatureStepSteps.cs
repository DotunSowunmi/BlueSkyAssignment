using BlueSkyProject3.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyProject3.StepDefinitions
{
    [Binding]
    public class DataDrivenwithFeatureStepSteps
    {
        AutomationTestingFormPage automationTestingFormPage;

        public DataDrivenwithFeatureStepSteps()
        {
            automationTestingFormPage = new AutomationTestingFormPage();
        }


        [Given(@"I navigate to site ""(.*)""")]
        public void GivenINavigateToSite(string url)
        {
            automationTestingFormPage.NavigateToFormwithParameter(url);
        }
        
        [When(@"I enter my email ""(.*)""")]
        public void WhenIEnterMyEmail(string email)
        {
            automationTestingFormPage.EnterEmail(email);
        }

        [When(@"I enter password ""(.*)""")]
        public void WhenIEnterPassword(string password)
        {
            automationTestingFormPage.EnterPassword(password);
        }
        
        [When(@"I click on submit button")]
        public void WhenIClickOnSubmitButton()
        {
            
        }
        
        [Then(@"the form is submitted")]
        public void ThenTheFormIsSubmitted()
        {
            
        }
    }
}
