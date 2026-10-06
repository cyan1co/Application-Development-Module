public class Circle
{
    const double PI = 3.14;
    public double radius = 5;

    public double CalculateArea()
    {
        return PI * radius * radius;
    }
        
    public double CalculatePerimeter()
    {
        return 2 * PI * radius;
    }
}

public class Program
{
    public static void Main(String[] args)
    {
        // Circle.PI = 5.2; Compilation Error due to PI being a compile-time constant which is fixed and cannot be reassigned anywhere in the program.

        Circle c = new Circle();
        
        Console.WriteLine("Area = " + c.CalculateArea());
        Console.WriteLine("Perimeter = " + c.CalculatePerimeter());
    }
}