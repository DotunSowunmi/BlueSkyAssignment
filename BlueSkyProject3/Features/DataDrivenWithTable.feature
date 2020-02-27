Feature: DataDrivenWithTable
	In order not to repeat my data or to be able to update my data
	I want to add my data to the feature file

@mytag
Scenario: Validate Form with Table
	Given I navigate to site "http://blueskycitadel.com/automation.testing.form/"
	When I enter my email and password
	| Email              | password   |
	| mytesting@test.com | mypassword |