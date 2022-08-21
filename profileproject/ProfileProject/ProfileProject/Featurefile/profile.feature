Feature: ProfileFeature

As a Seller I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details.


@SignIn
Scenario: 1.Confirmation of login with valid user name and password
	Given I logged into user account with valid username and password
	When I navigate to profile page
	
@AddLanguage
Scenario Outline: 2.Create new languages record with valid details
	Given I logged into website successsfully
	When I navigate to  languages tab in profile page
	And  I add new '<Language>','<Level>'languages details
	Then the languages details '<Language>','<Level>'should be created successfully
	Examples:
		| Language	| Level		|
		| Hindi		| Fluent	|



@EditLanguage
Scenario Outline: 3.Edit existing languages record with valid details
	Given I logged into website successsfully
	When I navigate to  languages tab 
	And I update existing '<Language>','<Level>' languages details
	Then the existing languages details'<Language>','<Level>' should be updated successfully
	Examples:
		| Language | Level	|
		| English  | Basic	|

	Scenario: 4.Delete existing language record
	Given I logged into website successsfully
	When I navigate to delete button in languages tab
	And I deleted existing language details
	Then the language details should be deleted successfully

@AddSkill
Scenario Outline: 5.Create new skills record with valid details
	Given I logged into website successsfully
	When I navigate to skills tab in profile page
	And  I add new '<Skill>','<Level>'skills details
	Then the skills details '<Skill>','<Level>'should be created successfully
	Examples:
		| Skill			| Level	|
		| Communication | Expert|

	Scenario Outline: 6.Edit existing skills record with valid details
	Given I logged into website successsfully
	When I navigate to edit button in skills tab
	And  I update existing '<Skill>','<Level>' skills details
	Then the existing skills details '<Skill>','<Level>' should be updated successfully
	Examples:
		| Skill	   | Level		|
		| Technical| Beginner	|


	Scenario: 7.Delete existing skills record
	Given I logged into website successsfully
	When I navigate to delete button
	And I deleted existing skills details
	Then the skills details should be deleted successfully


	Scenario Outline: 8.create education record with valid details
	Given I logged into website successsfully
	When I navigate to education tab in profile page
	And  I add new'<College>','<Country>','<Title>','<Degree>' and '<year>' details
	Then the Education details '<College>','<Country>','<Title>','<Degree>' and '<year>' should be created successfully
	Examples: 
	| College | Country | Title  | Degree | Year |
	| AUT     | India   | B.Tech | IT     | 2012 |
	

Scenario Outline: 9.Edit existing Education record with valid details
	Given I logged into website successsfully
	When I navigate to edit button in education tab
	And  I update existing '<College>','<Degree>' education details
	Then the '<College>','<Degree>' education details should be updated successfully
	Examples:
		| College | Degree	|
		| AUT     | DilpomaIT|


Scenario: 10.Delete existing Education record
	Given I logged into website successsfully
	When I navigate to delete button in Education tab
	And I deleted existing education details
	Then the education details should be deleted successfully

