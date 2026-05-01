using System.Runtime.CompilerServices;

namespace Example;

/// <summary>
/// 
/// </summary>
static class Program
{
    static void Main(string[] args)
    {
        string s1 = new string("B");
        string s2 = "ABC";
        string s3 = "DEFG";
        double d = 0.5;

        Console.WriteLine($"s1:{s1}");
        Console.WriteLine($"s2:{s2}");
        Console.WriteLine($"s3:{s3}");
        Console.WriteLine($"d:{d}");
        Console.WriteLine();
        Console.WriteLine($"s1.Length:{s1.Length}");
        Console.WriteLine($"s2.Length:{s2.Length}");
        Console.WriteLine();
        Console.WriteLine($"s1.CompareTo(s2):{s1.CompareTo(s2)}");
        Console.WriteLine($"s2.CompareTo(s3):{s2.CompareTo(s3)}");
        Console.WriteLine();
        string[] ss = s2.Split(s1);
        foreach(string s in ss)
        {
            Console.WriteLine($"s2.Split(s1){s}");
        }
        Console.WriteLine();
        Console.WriteLine($"string.Format(\"{{0:P}}\", d)}}:{string.Format("{0:P}", d)}");
    }
}

