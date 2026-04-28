using System.Runtime.CompilerServices;

namespace Example;

static class Program
{
    static void Main(string[] args)
    {
        PrintHello();

        int answer = Add(4,5);
        Console.WriteLine(answer);
    }

    static void PrintHello()
    {
        Console.WriteLine("Hello, World!");
    }

    static int Add(int x,int y)
    {
        return x + y;
    }
}

