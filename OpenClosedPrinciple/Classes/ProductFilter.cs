using OpenClosedPrinciple.Enums;

namespace OpenClosedPrinciple.Classes;

public class ProductFilter
{
    public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
    {
        foreach (var product in products)
        {
            if (product.Color == color)
            {
                yield return product;
            }
        }
    }
}