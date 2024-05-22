Feature: PageObjectModel


@test
Scenario: Get services details
	Given the user is on Home page
	When the user clicks on "Services" link
	Then the user is on "Services" page