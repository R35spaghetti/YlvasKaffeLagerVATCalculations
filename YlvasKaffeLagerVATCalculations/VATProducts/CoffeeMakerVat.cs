namespace YlvasKaffeLagerVATCalculations.VATProducts;

public class CoffeeMakerVat : ProductVat
{

    public override string? Product { get; set; }
    public override decimal VAT { get; set; } = 0.25m;
    public override decimal Price { get; set; }
    
    public decimal CalculateWithVat()
    {
        return Price + (Price * VAT);
    }
    public decimal CalculateWithoutVat()
    {
        return Price - (Price * VAT);
    }

}