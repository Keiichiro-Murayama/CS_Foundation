using System.Runtime.CompilerServices;

namespace Example;

static class Program
{
    static void Main(string[] args)
    {
        Warrior warrior2 =  new("AAA");
        System.Console.WriteLine(warrior2.name);
        System.Console.WriteLine(warrior2.hp);
    }
}

