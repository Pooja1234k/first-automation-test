Feature: ProfileFeature

As a Seller I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details.


@SignIn
Scenario: 01.Confirmation of login with valid user name and password
	Given I logged into user account with valid username and password
	When I navigate to profile page
	
@AddLanguage
Scenario Outline: 02.Create new languages record with valid details
	Given I logged into website successsfully
	When I navigate to  languages tab in profile page
	And  I add new '<Language>','<Level>'languages details
	Then the languages details '<Language>','<Level>'should be created successfully
	Examples:
		| Language	| Level		|
		| Hindi		| Fluent	|



@EditLanguage
Scenario Outline: 03.Edit existing languages record with valid details
	Given I logged into website successsfully
	When I navigate to  languages tab 
	And I update existing '<Language>','<Level>' languages details
	Then the existing languages details'<Language>','<Level>' should be updated successfully
	Examples:
		| Language | Level	|
		| English  | Basic	|

	Scenario: 04.Delete existing language record
	Given I logged into website successsfully
	When I navigate to delete button in languages tab
	And I deleted existing language details
	Then the language details should be deleted successfully

	Scenario:05 Verify validation error for language tab
	Given I left language field as blank
	Then error message should be displayed for language page

@AddSkill
Scenario Outline: 06.Create new skills record with valid details
	Given I logged into website successsfully
	When I navigate to skills tab in profile page
	And  I add new '<Skill>','<Level>'skills details
	Then the skills details '<Skill>','<Level>'should be created successfully
	Examples:
		| Skill			| Level	|
		| Communication | Expert|

	Scenario Outline: 07.Edit existing skills record with valid details
	Given I logged into website successsfully
	When I navigate to edit button in skills tab
	And  I update existing '<Skill>','<Level>' skills details
	Then the existing skills details '<Skill>','<Level>' should be updated successfully
	Examples:
		| Skill	   | Level		|
		| Technical| Beginner	|


	Scenario: 08.Delete existing skills record
	Given I logged into website successsfully
	When I navigate to delete button
	And I deleted existing skills details
	Then the skills details should be deleted successfully

	Scenario:09. Verify validation error for Skills tab
	Given I left skills field as blank
	Then error message should be displayed for skills page


	Scenario: 10.create education record with valid details
	Given I logged into website successsfully
	When I navigate to education tab in profile page
	And  I add new  education details
	Then The Education details should be created successfully
	
	

Scenario Outline: 11.Edit existing Education record with valid details
	Given I logged into website successsfully
	When I navigate to edit button in education tab
	And  I update existing '<College>','<Degree>' education details
	Then the '<College>','<Degree>' education details should be updated successfully
	Examples:
		| College | Degree    |
		| AUT     | DilpomaIT |


Scenario: 12.Delete existing Education record
	Given I logged into website successsfully
	When I navigate to delete button in Education tab
	And I deleted existing education details
	Then the education details should be deleted successfully

	Scenario:13. Verify validation error for education tab
	Given I left education field as blank
	Then error message should be displayed for education page

