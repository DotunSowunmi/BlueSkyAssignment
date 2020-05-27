Feature: DataDrivenWithExamples
	In order not to repeat my data or to be able to update my data
	I want to add my data to the feature file

@mytag
Scenario Outline: Validate Form Parameter
	Given I navigate to site "http://www.giftrete.com"
	And I navigate to site "https://blueskycitadel.com/automation-testing-form/"
	When I enter my email "<Email>"
	And I enter password "<Passwords>"
	And I click on submit button
	#Then the form is submitted

Examples: 
| Email                | Passwords           |
| yinkaland@gmail.com  | mysecuredPassword   |
|yinkaland@gmail.com   | mysecuredPassword2  |



