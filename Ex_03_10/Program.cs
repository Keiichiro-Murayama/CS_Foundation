namespace Ex_03_10;
using Ex_03_10.Modules;
using System.Dynamic;
using System.Reflection;
using System.Security;
using System.Security.Cryptography.X509Certificates;

static class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("DVDのタイトルを入力してください->");
        string media1 = Console.ReadLine();
        Player player1 = new DVDPlayer(media1);

        player1.Play();
        player1.Stop();

        System.Console.Write("Blu-rayのタイトルを入力してください->");
        string media2 = Console.ReadLine();
        Player player2 = new BlurayPlayer(media2);
        player2.Play();
        player2.Stop();
    
    }
}
