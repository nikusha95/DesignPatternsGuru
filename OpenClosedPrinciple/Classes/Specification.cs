namespace OpenClosedPrinciple.Classes;

public abstract class Specification<T>
{
   public abstract bool IsSatisfied(T item);
}