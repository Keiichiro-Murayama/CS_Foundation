using System.Security.Cryptography.X509Certificates;

namespace Ex_03_12.Modules;

public class BlurayPlayer:Player
{
    public BlurayPlayer(string Media):base(Media){}
    public override void Play()
    {
        System.Console.WriteLine($"Blu-ray:{Media}を再生しています");
    }

    public override void Stop()
    {
        System.Console.WriteLine($"Blu-ray:{Media}を再生を停止します");
    }

}