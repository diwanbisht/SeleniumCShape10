Feature: HotelSearch
this feature is applicable for Searching the Hotel


Scenario Outline: Validate Search Hotel
	Given I Navigated to Test Web Site
	When I enter the '<UserName>' and '<Password>'
	Then I should see the successfully login message or '<UserName>'
	When I select '<Location>'Value from Location drop down box
	When I select '<Hotels>'Value from Hotels drop down box
	When I select '<RoomType>'Value from Room Type drop down box
	When I select '<NumberofRooms>' Value from Number of Rooms drop down box
	When I enter '<CheckInDate>'Value from CheckIn field
	And I enter '<CheckOutDate>'Value from Chcekout field
	When I select '<AdultsperRoom>'Value from AdultsperRoom drop down box
	And  I click on 'Submit' button
	And  I click on 'radiobutton_0' button
	And  I click on 'continue' button

	
	
	
Examples: 
| UserName   | Password  | Location | Hotels      | RoomType | NumberofRooms | CheckInDate | CheckOutDate | AdultsperRoom |
| diwanbisht | Test@1234 | London   | Hotel Creek | Standard | 2 - Two       | 12/11/2022  | 15/11/2022   | 2 - Two       |



Scenario Outline: Validate Book A Hotel
	Given I Navigated to Test Web Site
	When I enter the '<UserName>' and '<Password>'
	Then I should see the successfully login message or '<UserName>'
	When I select '<Location>'Value from Location drop down box
	When I select '<Hotels>'Value from Hotels drop down box
	When I select '<RoomType>'Value from Room Type drop down box
	When I select '<NumberofRooms>' Value from Number of Rooms drop down box
	When I enter '<CheckInDate>'Value from CheckIn field
	And I enter '<CheckOutDate>'Value from Chcekout field
	When I select '<AdultsperRoom>'Value from AdultsperRoom drop down box
	And  I click on 'Submit' button
	And  I click on 'radiobutton_0' button
	And  I click on 'continue' button
	When I enter user First Name as 'Diwan'
	When I enter user Last Name as 'Bisht'
	When I enter user Address as 'B100, New Delhi -110002'
	When I enter user '<CardNumber>' Card Number
	When I select '<CardType>'from the dropdwon
	When I enter Card Expiry Year as '2022'
	When I select Card Expiry Month as 'June'	
	When I enter enter '123' as CVV number
	And  I click on 'book_now' button
	Then I should be navigated to 'Booking Confirmation' Page
	And I should get the Order Number

		
Examples: 
| UserName   | Password  | Location | Hotels      | RoomType | NumberofRooms | CheckInDate | CheckOutDate | AdultsperRoom | CardNumber       | CardType |
| diwanbisht | Test@1234 | London   | Hotel Creek | Standard | 2 - Two       | 12/11/2022  | 15/11/2022   | 2 - Two       | 4111111111111111 | VISA     |


