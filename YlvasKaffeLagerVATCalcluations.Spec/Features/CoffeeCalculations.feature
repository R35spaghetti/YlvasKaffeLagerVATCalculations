Feature: CoffeeVat
	Calculate price of coffee with VAT and without VAT

@PriceOfCoffeeWithVat
Scenario: Calculate with VAT
	Given the VAT for coffee is 0.06
	And the price of one coffee is 20
	When the price of one coffee is calculated with VAT
	Then the result should be 21.20
	
	@PriceOfCoffeeWithoutVat
	Scenario: Calculate without VAT
		Given the VAT for coffee is 0.06
		And the price of one coffee is 20
		When the price of one coffee is calculated without VAT
		Then the result should be 18.8

	
	
	
