namespace Ex_02_06;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("数値を入力してください->");
        int number = int.Parse(Console.ReadLine());

        if (number%4 ==0)
        {
            System.Console.WriteLine("４の倍数です。");
        }
        else
        {
            System.Console.WriteLine("４の倍数ではありません。");
        }
 
    }
}
