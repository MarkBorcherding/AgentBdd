Feature: Sending messages to growl
	In order to get notified of events that happen
	As a super cool developer
	I want to be able to send message to growl


Scenario: Sending a message to growl
	Given I have a growl application with the name of "Super Cool Growler"
	And there it has a notification type of "Sample Message" with and id of "sample_message"
	And the Growl application is registered
	When I send a "sample_message" message "Foo" with a title "Bar"
	Then you should have see it pop up


