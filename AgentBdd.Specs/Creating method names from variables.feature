Feature: Creating method names from variables
	In order to make writiing step definitions easier
	As a ReSharper user
	I want to be have my step method names suggested as I type my step


Scenario Outline: Suggest simple method names
	When I provide the step "<step description>"
	Then it should suggest <method name> as the method name

	Examples:
		| step description		| method name		|
		| the foo is cool		| the_foo_is_cool	|
		| the foo's bar			| the_foos_bar		|
		| the foo is "(.*)" bar | the_foo_is_bar	|
		| the baz is un-cool	| the_baz_is_uncool	|
		| the      foo is   coo | the_foo_is_coo	|
		| the foo should be (.*)| the_foo_should_be |