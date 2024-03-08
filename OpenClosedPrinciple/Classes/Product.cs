using OpenClosedPrinciple.Enums;

namespace OpenClosedPrinciple.Classes;

public class Product(string? name, Color color, Size size)
{
    public string? Name { get; set; } = name;
    public Color Color { get; set; } = color;
    public Size Size { get; set; } = size;
}