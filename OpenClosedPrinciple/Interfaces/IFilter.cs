using OpenClosedPrinciple.Classes;

namespace OpenClosedPrinciple.Interfaces;

public interface IFilter<T>
{
    IEnumerable<T> Filter(IEnumerable<T> items, Specification<T> spec);
}