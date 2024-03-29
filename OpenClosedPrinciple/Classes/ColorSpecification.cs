using OpenClosedPrinciple.Enums;
using OpenClosedPrinciple.Interfaces;

namespace OpenClosedPrinciple.Classes;

public class ColorSpecification(Color color) : Specification<Product>
{
    public override bool IsSatisfied(Product item)
    {
        return color == item.Color;
    }
}