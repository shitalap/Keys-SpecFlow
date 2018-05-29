Feature: Property Owner Login
	In order to Login using Table
	As a Property Owner
	I want to be told the steps 

@mytag
Scenario: SpecFlow_PO Login Table
	Given User is on Login Page
	When User enter crendentials
	| Key      | Value                   |
	| Username | shitalapatel1@gmail.com |
	| Password | test123                 |
	And click on Login 
	Then the user should navigate to PO Dashboard
