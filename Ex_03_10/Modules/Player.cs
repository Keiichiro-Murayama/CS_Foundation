namespace Ex_03_10.Modules;

public abstract class Player
{
    public string Media{set; get;}
    public Player(string Media)
    {
        this.Media = Media;
    }
    public abstract void Play();
    public abstract void Stop();

}