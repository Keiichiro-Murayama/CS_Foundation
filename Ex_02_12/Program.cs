namespace Ex_02_12;

static class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("値を入力してください->");
        int number = int.Parse(Console.ReadLine());
        int result = Mul3(number);
        System.Console.WriteLine(result);

    }

    static int Mul3(int a)
    {
        return a*3;
    }
}
