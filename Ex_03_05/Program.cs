using System.Net.ServerSentEvents;
using System.Runtime.CompilerServices;

namespace Ex_03_05;

static class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("商品番号を入力して下さい->");
        int itemNo = int.Parse(Console.ReadLine());

        System.Console.Write("商品名を入力して下さい->");
        string itemName = Console.ReadLine();
        
        System.Console.Write("価格を入力して下さい->");
        int price = int.Parse(Console.ReadLine());
        
        var item = new Item(pitemNo:itemNo, pitemName:itemName, pprice:price);
        item.Print();
    }
}
