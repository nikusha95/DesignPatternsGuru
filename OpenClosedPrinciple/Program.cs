// See https://aka.ms/new-console-template for more information

using OpenClosedPrinciple.Classes;
using OpenClosedPrinciple.Enums;

var apple = new Product("Apple", Color.Green, Size.Small);
var tree = new Product("Tree", Color.Green, Size.Large);
var house = new Product("House", Color.Blue, Size.Large);

Product[] products = { apple, tree, house };
var pf = new ProductFilter();
Console.WriteLine("Green products:");
foreach (var p in pf.FilterByColor(products, Color.Green))
    Console.WriteLine($" - {p.Name} is green");