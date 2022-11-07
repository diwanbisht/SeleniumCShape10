Feature: LoginFeatures
	This feature is applicable for Login Functionality


Scenario: Valid User Login 
	Given I Navigated to Test Web Site
	When I enter the 'AdminTest1' and 'Test@1234'
	Then I should see the successfully login message or User
	

