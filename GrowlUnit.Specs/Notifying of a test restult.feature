Feature: Test result notitifcation	
	In order to know when tests fail or pass 
	As an awesome developer
	I want to listen to the NUnit gui and send message to Growl

@mytag
Scenario: Tests pass
	Given I have a growl notifier
	When my tests results pass
	Then I should see the a success message

Scenario: Tests fail
	Given I have a growl notifier
	When my tests results fail
	Then I should see the a failure message

Scenario: Tests throw an exception
	Given I have a growl notifier
	When my tests throw an exception
	Then I should see the a failure message
