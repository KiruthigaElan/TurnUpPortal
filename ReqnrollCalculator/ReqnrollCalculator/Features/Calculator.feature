Feature: Calculator

Simple calculator for adding two numbers

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the numbers are added
	Then the result should be 120

	Scenario: Subtract two numbers
	Given the first number is 50
	And the second number is 70
	When the numbers are subtracted
	Then the result should be -20

	Scenario: Multiply two numbers
	Given the first number is 50
	And the second number is 70
	When the numbers are multiplied
	Then the result should be 3500

	Scenario: Divide two numbers
	Given the first number is 50
	And the second number is 5
	When the numbers are divided
	Then the result should be 10
