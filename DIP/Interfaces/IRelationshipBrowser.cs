using DIP.Classes;

namespace DIP.Interfaces;

public interface IRelationshipBrowser
{
    IEnumerable<Person> FindAllChildrenOf(string name);
}