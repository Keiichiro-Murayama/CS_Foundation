namespace Ex_03_11.Modules;

public class FlashMemory : IUSB
{
    public void SendData()
    {
        System.Console.WriteLine("フラッシュメモリに記録してあるデータをPCに送りました");
    }

    public void ReciveData()
    {
        System.Console.WriteLine("PCのデータをフラッシュメモリに記録しました");
    }
}