using System.Security.Cryptography.X509Certificates;

namespace Ex_03_10.Modules;

public class DVDPlayer:Player
{
    public DVDPlayer(string Media):base(Media){}

    public override void Play()
    {
        System.Console.WriteLine($"DVD:{Media}を再生しています");
    }

    public override void Stop()
    {
        System.Console.WriteLine($"DVD:{Media}を再生を停止します");
    }
}