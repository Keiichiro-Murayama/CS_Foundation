namespace Ex_02_05;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("数値を入力してください->");
        int number = int.Parse(Console.ReadLine());

        if (number%2 ==0)
        {
            number *= 10;
        }

        System.Console.WriteLine($"結果:{number}");
    }
}
