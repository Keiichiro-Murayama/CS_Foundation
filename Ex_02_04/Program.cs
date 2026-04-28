using System.Globalization;

namespace Ex_02_04;

static class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("数値１を入力してください->");
        var num1 = int.Parse(System.Console.ReadLine());
        System.Console.WriteLine("数値2を入力してください->");
        var num2 = int.Parse(System.Console.ReadLine());
        System.Console.WriteLine("数値3を入力してください->");
        var num3 = int.Parse(System.Console.ReadLine());

        int[] nums = {num1, num2, num3};

        System.Console.WriteLine($"数値1：{nums[0]}");
        System.Console.WriteLine($"数値2：{nums[1]}");
        System.Console.WriteLine($"数値3：{nums[2]}");

    }
}
