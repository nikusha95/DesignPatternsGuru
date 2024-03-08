using OpenClosedPrinciple.Enums;
using OpenClosedPrinciple.Interfaces;

namespace OpenClosedPrinciple.Classes;

public class ColorSpecification(Color color) : ISpecification<Product>
{
    public bool IsSatisfied(Product item)
    {
        return color == item.Color;
    }
}