namespace Ex_02_07;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("数値を入力してください->");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            System.Console.WriteLine("正の値です。");
        }
        else if (number < 0)
        {
            System.Console.WriteLine("負の値です。");
        }
        else if (number == 0)
        {
            System.Console.WriteLine("0です。");
        }

    }
}
