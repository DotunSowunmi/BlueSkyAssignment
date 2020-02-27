Feature: BlueSkyCitadelTestingForm
	In order to be a guru tester
	Iwant test the BlueSky Citadel Testing
	which has lot of elements I will be automating in future

@regression @blueskyform
Scenario: Valid form Submission
	Given I navigate to the Bluesky Testing form 
	When I enter the single Line Text
	 And I select One in the select box
	 And I enter Email
	 And I enter my password
	 And I select the Multi-select
	 And I select the Radio List
	 And I select the Checkbox List
	 And I select United Kingdom as Country
	 And I select date from current month
	 And I click on the Submit button
	#Then the message "Your form has been successfully submitted."
