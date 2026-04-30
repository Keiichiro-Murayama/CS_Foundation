namespace Ex_03_07;

public class Item
{
    public  int ItemNo {get; set;}
    public string ItemName{get; set;}
    public int Price{get; set;}

    public void Print()
    {
        System.Console.WriteLine("結果");
        System.Console.WriteLine($"商品番号 = {ItemNo}");
        System.Console.WriteLine($"商品名 = {ItemName}");
        System.Console.WriteLine($"価格 = {Price}");
    }
}