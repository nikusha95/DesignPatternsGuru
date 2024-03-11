using DIP.Enums;
using DIP.Interfaces;

namespace DIP.Classes;

public class Research
{
    /// <summary>
    /// !!!<br></br>BAD APPROACH IT IS DEPEND ON <b>Relationship</b> class <br></br>!!!
    /// </summary>
    public Research(IRelationshipBrowser relationships)
    {
        var relations = relationships.FindAllChildrenOf("John");
        foreach (var r in relations)
        {
            Console.WriteLine($"John has a child {r.Name}");
        }
    }
}