Feature: ValtechTestFeatures
	
@mytag
Scenario: VerifyBlogTitle
	Given I am on valtech website
	Then I can verify that Recent blogs link is displayed
	And when I click the first article
	Then I can verify page title

Scenario Outline: VerifyTagTexts 
    Given I am on valtech website
	When I click <link> Link
	Then I can verify tag texts <tagTexts>

	Examples: 
	| slno     | tagTexts | link     |
	| services | Services | Services |
	| About    | About    | About    |
	| Work     | Work     | Work     |
	
	

	