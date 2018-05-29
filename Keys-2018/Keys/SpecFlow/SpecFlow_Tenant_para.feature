Feature: Tenant Login
	In order to Login 
	As a Tenant user
	I want to be told the steps to login and naigate to Tenant My Rentals Page

@mytag
Scenario Outline: SpecFlow_Tenant user Login Para
	Given user is on Login Page
	When user have entered <username> and <password>
	And Click on Login and Click on Tenants My Rentals option
	Then the user is navigated to Tenants My Rental Page

Examples:
| username              | password |
| tenantuser@cryp.email | test123  |

