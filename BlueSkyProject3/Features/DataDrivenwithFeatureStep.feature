Feature: DataDrivenwithFeatureStep
	In order not to repeat my data or to be able to update my data
	I want to add my data to the feature file

@mytag
Scenario: Validate Form Parameter
	Given I navigate to site "https://blueskycitadel.com/automation-testing-form/"
	When I enter my email "yinkaland@gmail.com"
	And I enter password "mysecuredPassword"
	#And I click on submit button
	Then the form is submitted
