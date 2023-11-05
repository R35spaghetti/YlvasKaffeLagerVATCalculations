Feature: CoffeeMakerCalculations
Calculate price of coffeemaker with VAT and without VAT

@PriceOfACoffeeMakerWithVat
Scenario: Calculate VAT
	Given the VAT for a Coffee Maker is 0.25
	And the price of a Coffee Maker is 150
	When the price of a Coffee Maker is calculated with VAT
	Then the result will be 187.5
	
	
@PriceOfACoffeeMakerWithoutVat
	Scenario: Calculate without VAT
		Given the VAT for a Coffee Maker is 0.25
		And the price of a Coffee Maker is 150
		When the price of a Coffee Maker is calculated without VAT
		Then the result will be 112.5