using System.Diagnostics.Contracts;

namespace Ex_03_06;

// <summary>
//商品情報を表すクラス 
// <summary>

public class  Item
{
    public int itemNo; //商品番号
    public string itemName; //商品名
    public int price; //単価

    // コンストラクタ
    public Item(){}
    public Item(int pitemNo, string pitemName):this(pitemNo, pitemName,0)
    {
        this.itemNo = pitemNo;
        this.itemName = pitemName;
    }
    public Item (int pitemNo, string pitemName, int pprice)
    {
        this.itemNo = pitemNo;
        this.itemName = pitemName;
        this.price = pprice;
    }

    //商品情報の出力
    public void Print()
    {
        System.Console.WriteLine("結果");
        System.Console.WriteLine($"商品番号 = {itemNo}");
        System.Console.WriteLine($"商品名 = {itemName}");
        System.Console.WriteLine($"価格 = {price}");
    }

    public void ChangePrice(int price)
    {
        this.price = price;
    }

    public void ChangePrice(string price)
    {
        this.price = int.Parse(price);
    }

}
