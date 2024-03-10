using OpenClosedPrinciple.Interfaces;

namespace OpenClosedPrinciple.Classes;

public class AndSpecification<T>(Specification<T> first, Specification<T> second) : Specification<T>
{
    public override bool IsSatisfied(T item)
    {
        return first.IsSatisfied(item) && second.IsSatisfied(item);
    }
}