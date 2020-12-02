Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Addieren
	Given the first number is 30
	And the second number is 10
	When the two numbers are addiert
	Then the result should be 40

Scenario: Subtrahieren
	Given the first number is 30
	And the second number is 10
	When the two numbers are subdrahiert
	Then the result should be 20


Scenario: Multiplizieren
	Given the first number is 30
	And the second number is 10
	When the two numbers are multipliziert
	Then the result should be 300

Scenario: Dividieren
	Given the first number is 30
	And the second number is 10
	When the two numbers are dividiert
	Then the result should be 3