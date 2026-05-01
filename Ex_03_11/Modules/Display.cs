namespace Ex_03_11.Modules;

public class Display : IUSB
{
    public void SendData()
    {
        System.Console.WriteLine("NotImplementedExceptionをスローする");
    
    }

    public void ReciveData()
    {
        System.Console.WriteLine("ディスプレイに表示する情報を受信しました");
    }
}