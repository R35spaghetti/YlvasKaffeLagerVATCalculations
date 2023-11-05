namespace YlvasKaffeLagerVATCalculations.VATProducts.Interfaces;



public interface IProductVat
{
    public  string? Product { get; set; }

    public decimal VAT { get; set; }
     
    public decimal Price { get; set; }


}