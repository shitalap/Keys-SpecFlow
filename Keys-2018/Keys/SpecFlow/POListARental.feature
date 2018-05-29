Feature: PO List A Rental
	In order to List A Rental
	As a Property Owner
	

@mytag
Scenario: SpecFlow_POListARental
	Given I have Navigated to List A Rental
	And I have entered valid mandatory fields and press Save
	Then the property listed is verified

	