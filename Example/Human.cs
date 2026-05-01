/// <summary>
/// 人物を表すクラス
/// </summary>
namespace Example;
public class Human
{
    public string Name { get; set; }
    public int Hp { get; private set; }

    public void Greet()
    {
        Console.WriteLine("Hi!");
    }

    public void Defence(int damage)
    {
        Hp -= damage;
    }
}