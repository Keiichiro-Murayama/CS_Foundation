using System.Net.ServerSentEvents;

namespace Ex_03_01;

static class Program
{
    static void Main(string[] args)
    {
        var item = new Item();

        System.Console.WriteLine("商品番号を入力して下さい->");
        item.itemNo = int.Parse(Console.ReadLine());

        System.Console.WriteLine("商品名を入力して下さい->");
        item.itemName = Console.ReadLine();
        
        System.Console.WriteLine("価格を入力して下さい->");
        item.price = int.Parse(Console.ReadLine());


        System.Console.WriteLine("結果");
        System.Console.WriteLine($"商品番号 = {item.itemNo}");
        System.Console.WriteLine($"商品名 = {item.itemName}");
        System.Console.WriteLine($"価格 = {item.price}");
    }
}
