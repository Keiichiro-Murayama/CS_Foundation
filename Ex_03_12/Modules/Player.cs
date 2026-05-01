namespace Ex_03_12.Modules;

public abstract class Player
{
    public string Media{set; get;}
    public Player(string Media)
    {
        this.Media = Media;
    }
    public abstract void Play();
    public abstract void Stop();

    public void UseMachine()
    {
        Play();
        Stop();
    }

}