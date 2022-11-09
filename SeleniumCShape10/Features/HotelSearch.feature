Feature: HotelSearch
this feature is applicable for Searching the Hotel


Scenario Outline: Validate Search Hotel
	Given I Navigated to Test Web Site
	When I enter the '<UserName>' and '<Password>'
	Then I should see the successfully login message or '<UserName>'
	When I select '<Location>' from drop down box
	When I select Hotel from drop down box
	When I select Room Type  from drop down box
	When I select Number of Rooms  from drop down box
	When I enter CheckIndate
	When I enter CheckOutDate
	

	
	

Examples: 
| UserName   | Password  | Location |
| diwanbisht | Test@1234 | London   |