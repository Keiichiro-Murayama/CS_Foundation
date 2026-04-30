namespace Ex_03_09;

using System.Runtime.InteropServices;
using Ex_03_09.Modules;

static class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("口座番号を入力してください->");
        string accountNo = Console.ReadLine();

        System.Console.Write("口座名義を入力してください->");
        string accountName = Console.ReadLine();
        
        System.Console.Write("残高を入力してください->");
        int balance = int.Parse(Console.ReadLine());

        System.Console.Write("ポイントを入力してください->");
        int point = int.Parse(Console.ReadLine());

        var netAccount = new NetAccount(
            accountNo, accountName, balance, point);
        netAccount.Print();
        System.Console.WriteLine(netAccount.ToString());
    }
}
