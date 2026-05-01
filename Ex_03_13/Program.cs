using System.Runtime.InteropServices;

namespace Ex_03_13;

static class Program
{
    static void Main(string[] args)
    {
        var circle = new Circle(10);
        System.Console.WriteLine($"5*5*3.14 = {circle.AreaCalculation()}");
        System.Console.WriteLine($"5*5*3.14 ={Circle.AreaCalculation(5)}");
        Circle.PI = 3;
        System.Console.WriteLine($"5*5*3 ={circle.AreaCalculation()}");
        System.Console.WriteLine($"5*5*3 ={Circle.AreaCalculation(5)}");
      
    }
}
