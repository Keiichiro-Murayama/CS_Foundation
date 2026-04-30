using System.Net.NetworkInformation;
using Ex_03_08.Modules;
namespace Ex_03_08;

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

        var netAccount = new NetAccount();
        netAccount.AccountNo = accountNo;
        netAccount.AccountName = accountName;
        netAccount.Balance = balance;
        netAccount.Point=point;
        netAccount.Print();
    }
}
