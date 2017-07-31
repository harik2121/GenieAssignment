Feature: SearchProducts
	As a online user, I want to validate search results for Genie/Gentu products on Genie Solutions web page


Scenario: Search and verify Genie/gentu products on Genie solutions webpage
	Given I go to the Genie Solutions web page
	#Replace the search parameter with 'gentu" for gentu prodcuts
	When I search for 'genie' prodcuts
	Then Verify search results includes 'genie' products




