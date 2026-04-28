using System.Runtime.CompilerServices;

namespace Example;

static class Program
{
    static void Main(string[] args)
    {
        // インスタンスの生成
        Warrior warrior = new();
        // フィールドに値を設定する
        warrior.name = "ユータ";
        warrior.dp = 3;
        // フィールドの値を取得する
        string name = warrior.name;
        Console.WriteLine($"{name}のHP：{warrior.hp}");
        Console.WriteLine($"{name}の攻撃力：{warrior.ap}");
        Console.WriteLine($"{name}の防御力：{warrior.dp}");
    }
}

