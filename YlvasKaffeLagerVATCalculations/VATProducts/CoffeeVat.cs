namespace YlvasKaffeLagerVATCalculations.VATProducts;

public class CoffeeVat : ProductVat
{

    public override decimal VAT { get; set; } = 0.06m;
    public override decimal Price { get; set; }

    public override string? Product { get; set; }
    
    public decimal CalculateWithVat()
    {
        return Price + (Price * VAT);
    }
    public decimal CalculateWithoutVat()
    {
        return Price - (Price * VAT);
    }


    
}