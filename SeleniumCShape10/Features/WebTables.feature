Feature: WebTables
	This feature is applicable for Testing the WebTable Features


Scenario Outline: Validate WebTable
	Given I Navigated to Test the WebTable
	When I would like to get the value of Second Row
	When I would like to get the value of Second Column
	Then I validate the 'Francisco Chang' contact person
	Then I validate all the values from specific columns as 'Contact'
	Then I validate all the values from specific columns as 'Country'
	Then I validate all the values from specific columns by ColumnIndex as 1


Examples:
	| UserName   | Password  |
	| diwanbisht | Test@1234 |