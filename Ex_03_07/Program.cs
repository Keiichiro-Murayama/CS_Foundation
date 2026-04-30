using System.Net.ServerSentEvents;

using Ex_03_07;
namespace Ex_03_07;

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

        var item = new Item();
        item.ItemNo = itemNo;
        item.ItemName = itemName;
        item.Price = price;
        item.Print();

    }
}
