namespace RunProgram.Classes;

public class Circle
{
    public double Radius { get; set; }
    public double Area => Math.PI * Radius * Radius;
    
    public Circle(double radius)
    {
        Radius = radius;
    }
    
    public void DisplayShapeInfo()
    {
        Console.WriteLine($"Shape: Circle");
        Console.WriteLine($"Radius: {Radius}");
        Console.WriteLine($"Area: {Area:F2}");
        Console.WriteLine("--------------------");
    }
}