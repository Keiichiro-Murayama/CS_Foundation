using System.Net.Http.Headers;

namespace Ex_03_13;

/// <summary>
/// 
/// </summary>
public class Circle
{
    public static double PI = 3.14;
    int radius;

/// <summary>
/// 
/// </summary>
/// <param name="pradius"></param>
    public Circle(int pradius)
    {
        this.radius = pradius;
    }
    public double AreaCalculation()
    {
        return radius * radius * PI;
    }

    public static double AreaCalculation(int radius)
    {
        return radius * radius* PI;
    }
}