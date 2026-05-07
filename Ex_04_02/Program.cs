namespace Ex_04_02;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("年を入力してください->");
        int year = int.Parse(Console.ReadLine());
        if (DateTime.IsLeapYear(year))
        {
            System.Console.WriteLine($"{year}は閏年です。");
        }else
        {
            System.Console.WriteLine($"{year}は閏年ではありません。");
        }
    }
}
