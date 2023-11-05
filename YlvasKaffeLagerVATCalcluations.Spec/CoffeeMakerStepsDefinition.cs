using FluentAssertions;
using YlvasKaffeLagerVATCalculations.VATProducts;

namespace YlvasKaffeLagerVATCalculations.Spec;

[Binding]
public class CoffeeMakerStepsDefinition
{

    private readonly CoffeeMakerVat _coffeMakerVat = new CoffeeMakerVat();
    private decimal _result;

    
    [Given(@"the VAT for a Coffee Maker is (.*)")]
    public void GivenTheVatForACoffeeMakerIs(decimal p0)
    {
        _coffeMakerVat.VAT = p0;
    }

    [Given(@"the price of a Coffee Maker is (.*)")]
    public void GivenThePriceOfACoffeeMakerIs(decimal p0)
    {
        _coffeMakerVat.Price = p0;
    }

    [When(@"the price of a Coffee Maker is calculated with VAT")]
    public void WhenThePriceOfACoffeeMakerIsCalculatedWithVat()
    {
        _result += _coffeMakerVat.CalculateWithVat();
    }


    [When(@"the price of a Coffee Maker is calculated without VAT")]
    public void WhenThePriceOfACoffeeMakerIsCalculatedWithoutVat()
    {
        _result += _coffeMakerVat.CalculateWithoutVat();

    }

    [Then(@"the result will be (.*)")]
    public void ThenTheResultWillBe(decimal p0)
    {
        _result.Should().Be(p0);

    }
}