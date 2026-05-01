namespace Ex_03_11.Modules;

public class Mouse : IUSB
{
    public void SendData()
    {
        System.Console.WriteLine("PCにマウスの移動情報を送信しました");
    }

    public void ReciveData()
    {
        System.Console.WriteLine("NotImplementedExceptionをスローする");
    }
}