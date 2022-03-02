
Feature: SpecFlowFeature1
	Simple calculator for adding two numbers

@mytag
Scenario: Simple 2000
	Given input of 2000
	When converted to Roman numerals
	Then the result should be MM
Scenario: 3
	Given input of 3
	When converted to Roman numerals
	Then the result should be III
Scenario: 4
	Given input of 4
	When converted to Roman numerals
	Then the result should be IV
Scenario: 5
	Given input of 5
	When converted to Roman numerals
	Then the result should be V
Scenario: Simple 6
	Given input of 6
	When converted to Roman numerals
	Then the result should be VI
Scenario: 8
	Given input of 8
	When converted to Roman numerals
	Then the result should be VIII
Scenario: 9
	Given input of 9
	When converted to Roman numerals
	Then the result should be IX
Scenario: 10
	Given input of 10
	When converted to Roman numerals
	Then the result should be X
Scenario: 11
	Given input of 11
	When converted to Roman numerals
	Then the result should be XI
Scenario: 27
	Given input of 27
	When converted to Roman numerals
	Then the result should be XXVII
Scenario: 29
	Given input of 29
	When converted to Roman numerals
	Then the result should be XXIX
Scenario: 30
	Given input of 30
	When converted to Roman numerals
	Then the result should be XXX
Scenario: 31
	Given input of 31
	When converted to Roman numerals
	Then the result should be XXXI
Scenario: 777
	Given input of 777
	When converted to Roman numerals
	Then the result should be DCCLXXVII
Scenario: 999
	Given input of 999
	When converted to Roman numerals
	Then the result should be CMXCIX
Scenario: 1999
	Given input of 1999
	When converted to Roman numerals
	Then the result should be MCMXCIX
Scenario: 2021
	Given input of 2021
	When converted to Roman numerals
	Then the result should be MMXXI
Scenario: 0
	Given input of 0
	When converted to Roman numerals
	Then the result will be blank
Scenario: 4000
	Given input of 4000
	When converted to Roman numerals
	Then HeberSaid an ExceptionWasThrown
Scenario: -1
	Given input of -1
	When converted to Roman numerals
	Then HeberSaid an ExceptionWasThrown
Scenario: -100
	Given input of -100
	When converted to Roman numerals
	Then HeberSaid an ExceptionWasThrown



