using DIP.Enums;
using DIP.Interfaces;

namespace DIP.Classes;

public class Relationships:IRelationshipBrowser
{
    private List<(Person, Relationship, Person)> _relations = new();

    public void AddParentChild(Person parent, Person child)
    {
        _relations.Add((parent, Relationship.Parent, child));
       _relations.Add((child, Relationship.Child, parent));
    }

    public IEnumerable<Person> FindAllChildrenOf(string name)
    {
        return _relations
            .Where(x => x.Item1.Name == name
                        && x.Item2 == Relationship.Parent)
            .Select(r => r.Item3);
    }
}