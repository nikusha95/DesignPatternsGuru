using OpenClosedPrinciple.Enums;
using OpenClosedPrinciple.Interfaces;

namespace OpenClosedPrinciple.Classes;

public class SizeSpecification(Size size):Specification<Product>
{
    public override bool IsSatisfied(Product item)
    {
        if (item.Size == size)
        {
            return true;
        }
        return false;
    }
}