namespace LSP.Classes;

public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int Area => Width * Height;

    public Rectangle()
    {
    }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
}