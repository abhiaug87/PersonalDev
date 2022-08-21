Feature: Scenarios for restrictions feature

@Chrome
Scenario: Cancel out of the Restrictions page
	Given I have logged into Confluence
	And I click on the Confluence link
	When I click on my space
	And I am redirected to the Overview page
	And I navigate to the restrictions page
	When I click the cancel button
	Then I am redirected to the Overview page

@Chrome
Scenario: Add restriction - anyone can view & edit
	Given I have logged into Confluence
	And I click on the Confluence link
	When I click on my space
	And I am redirected to the Overview page
	And I navigate to the restrictions page
	When I choose the permission
	Then I am able to add the user

@Chrome
Scenario: Add restriction - anyone can view & some can edit
	Given I have logged into Confluence
	And I click on the Confluence link
	When I click on my space
	And I am redirected to the Overview page
	And I navigate to the restrictions page
	When I choose the permission for this scenario
	And I choose the user for this scenario
	Then I am able to add the user

@Chrome
Scenario: Delete user - anyone can view & some can edit restriction
	Given I have logged into Confluence
	And I click on the Confluence link
	When I click on my space
	And I am redirected to the Overview page
	And I navigate to the restrictions page
	When I click on the remove button
	Then the user is removed

@Chrome
Scenario: Modify restriction after adding user - specific people can view or edit restriction
	Given I have logged into Confluence
	And I click on the Confluence link
	When I click on my space
	And I am redirected to the Overview page
	And I navigate to the restrictions page
	When I choose the permission to a specific user
	And I choose the user
	And click on edit
	Then I am able to add the user

@Chrome
Scenario: Remove user - specific people can view or edit restriction
	Given I have logged into Confluence
	And I click on the Confluence link
	When I click on my space
	And I am redirected to the Overview page
	And I navigate to the restrictions page
	When I click on the remove button
	Then the user is removed
