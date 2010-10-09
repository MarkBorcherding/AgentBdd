Feature: Formatting Growl messages
	In order to know the status of each test run
	As a person who loves writing tests
	I want to see useful message about the previous run

@mytag
Scenario: Successful test runs
	Given I have a test result of all successful testS
	When I format my growl message
	Then the title should be "Success"
	And the message should be "All green."
