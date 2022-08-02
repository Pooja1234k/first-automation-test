 Feature: TMFeature

 As a TurnUp portal admin
 I would like to create,edit and delete time and material records
 So that i can manage employees time and material successfully

@mytag
Scenario: 1.Create material record with vaild details
	Given I logged into turnup portal successfully
	When I navigate to time and material page
	When I create a new material record
	Then The record should be able to record successfully
	
	@yourtag
	Scenario Outline: 2.Edit existing material record with valid data
	Given I logged into turnup portal successfully
	When I navigate to time and material page
	When I updated the '<Code>','<Description>','<Price>' of an existing material record
	Then The record Should have '<Code>','<Description>','<Price>' updated

		Examples: 
	| Code     | Description | Price   |
	| Keyboard | White       | $100.00 |
	| Bottle   | Green       | $20.00  |
	| Pen      | Bue         | $10.00  |

	
	
	Scenario: 3. Delete existing material record 
	Given I logged into turnup portal successfully
	When I navigate to time and material page
	When I deleted the '<Code>','<Description>','<Price>' of an existing material record
	Then The record Should have '<Code>','<Description>','<Price>' deleted


	
	


