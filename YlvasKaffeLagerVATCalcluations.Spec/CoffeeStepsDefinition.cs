using FluentAssertions;
using YlvasKaffeLagerVATCalculations.VATProducts;

namespace YlvasKaffeLagerVATCalcluations.Spec;

[Binding]
public class CoffeeStepsDefinition
{
    private readonly CoffeeVat _coffeeVat = new CoffeeVat();
    private decimal _result;

    [Given(@"the VAT for coffee is (.*)")]
    public void GivenTheVatForCoffeeIs(decimal p0)
    {
        _coffeeVat.VAT = p0;
    }

    [Given(@"the price of one coffee is (.*)")]
    public void GivenThePriceOfOneCoffeeIs(int p0)
    {
        _coffeeVat.Price = p0;
    }

    [When(@"the price of one coffee is calculated with VAT")]
    public void WhenThePriceOfOneCoffeeIsCalculatedWithVat()
    {
        _result += _coffeeVat.CalculateWithVat();
    }

    [When(@"the price of one coffee is calculated without VAT")]
    public void WhenThePriceOfOneCoffeeIsCalculatedWithoutVat()
    {
        _result += _coffeeVat.CalculateWithoutVat();
    }

    [Then(@"the result should be (.*)")]
    public void ThenTheResultShouldBe(decimal p0)
    {
        _result.Should().Be(p0);
    }
}