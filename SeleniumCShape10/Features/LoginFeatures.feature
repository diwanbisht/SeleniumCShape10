Feature: LoginFeatures
	This feature is applicable for Login Functionality


Scenario Outline: Valid User Login 
	Given I Navigated to Test Web Site
	When I enter the '<UserName>' and '<Password>'
	Then I should see the successfully login message or '<UserName>'
	

Examples: 
| UserName   | Password  |   
| diwanbisht | Test@1234 | 