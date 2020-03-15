Feature: DataDrivenwithFeatureStep
	In order not to repeat my data or to be able to update my data
	I want to add my data to the feature file

@mytag
Scenario: Validate Form
	Given I navigate to site "http://www.giftrete.com"
	When I enter my email "mytest@test.com"
	And I enter password "mysecuredPassword"
	#And I click on submit button
	#Then the form is submitted
