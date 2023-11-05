using YlvasKaffeLagerVATCalculations.VATProducts.Interfaces;

namespace YlvasKaffeLagerVATCalculations.VATProducts;

public abstract class ProductVat : IProductVat
{

    public abstract string? Product { get; set; }
    public abstract decimal VAT { get; set; }
    public abstract decimal Price { get; set; }

   
 
}