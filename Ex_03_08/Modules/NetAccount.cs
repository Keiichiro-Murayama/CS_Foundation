namespace Ex_03_08.Modules;

public class NetAccount : Account
{
    public int Point { get; set; }

    public void Print()
    {
        System.Console.WriteLine($"口座番号:{AccountNo} 口座名義:{AccountName} 残高:{Balance} ポイント:{Point}");
    }
}