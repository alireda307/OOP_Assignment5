namespace RunProgram.Classes;

public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double Area => Width * Height;
    
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    
    public void DisplayShapeInfo()
    {
        Console.WriteLine($"Shape: Rectangle");
        Console.WriteLine($"Width: {Width}");
        Console.WriteLine($"Height: {Height}");
        Console.WriteLine($"Area: {Area:F2}");
        Console.WriteLine("--------------------");
    }
}