Feature: ProfileFeature

As a Seller I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details.


@SignIn
Scenario: Confirmation of login with valid user name and password
	Given I logged into user account with valid username and password
	When I navigate to profile page
	
@AddLanguage
Scenario: Create new languages record with valid details
	Given I logged into website successsfully
	When I navigate to  languages tab in profile page
	And  I add new languages details
	Then the languages details should be created successfully
	

@EditLanguage
Scenario Outline: Edit existing languages record with valid details
	Given I logged into website successsfully
	When I navigate to edit button in languages tab
	And  I update existing '<Language>','<Level>' languages details
	Then the existing languages details'<Language>','<Level>' should be updated successfully
	Examples:
		| Language | Level  |
		| English  | Fluent |

	Scenario: Delete existing language record
	Given I logged into website successsfully
	When I navigate to delete button in languages tab
	And I deleted existing language details
	Then the language details should be deleted successfully

@AddSkill
Scenario: Create new skills record with valid details
	Given I logged into website successsfully
	When I navigate to skills tab in profile page
	And  I add new skills details
	Then the skills details should be created successfully
	

	Scenario Outline: Edit existing skills record with valid details
	Given I logged into website successsfully
	When I navigate to edit button in skills tab
	And  I update existing '<Skill>','<Level>' skills details
	Then the existing skills details '<Skill>','<Level>' should be updated successfully
	Examples:
		| Skill	   | Level	|
		| Technical| Basic	|


	Scenario: Delete existing skills record
	Given I logged into website successsfully
	When I navigate to delete button
	And I deleted existing skills details
	Then the skills details should be deleted successfully


Scenario: Create new Education record with valid details
	Given I logged into website successsfully
	When I navigate to education tab in profile page
	And  I add new Education details
	Then the Education details should be created successfully
	

Scenario Outline: Edit existing Education record with valid details
	Given I logged into website successsfully
	When I navigate to edit button in education tab
	And  I update existing '<College>','<Degree>' education details
	Then the '<College>','<Degree>' education details should be updated successfully
	Examples:
		| College | Degree	|
		| AUT     | DilpomaIT|


Scenario: Delete existing Education record
	Given I logged into website successsfully
	When I navigate to delete button in Education tab
	And I deleted existing education details
	Then the education details should be deleted successfully

