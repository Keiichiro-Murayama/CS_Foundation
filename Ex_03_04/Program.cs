using System.Runtime.InteropServices;

namespace Ex_03_04;

static class Program
{
    static void Main(string[] args)
    {
        var item = new Item();

        System.Console.Write("商品番号を入力して下さい->");
        item.itemNo = int.Parse(Console.ReadLine());

        System.Console.Write("商品名を入力して下さい->");
        item.itemName = Console.ReadLine();
        
        System.Console.Write("価格を入力して下さい->");
        item.price = int.Parse(Console.ReadLine());

        System.Console.Write("新しい単価を入力して下さい->");
        item.ChangePrice(int.Parse(Console.ReadLine()));
        
        System.Console.Write(item.CalculateTaxAmount());
    }
}
