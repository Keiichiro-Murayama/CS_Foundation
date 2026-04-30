/// <summary>
/// 戦士を表すクラス
/// </summary>

namespace Example;
public class Warrior
{
    public string name;     // 名前を表すフィールド
    public int hp;     // 体力を表すフィールド


    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="pname">nameフィールドに設定する値</param>
    /// <param name="php">hpフィールドに設定する値</param>
    public Warrior(string name)
    {
        this.name = name;
        this.hp = 1;
    }

}