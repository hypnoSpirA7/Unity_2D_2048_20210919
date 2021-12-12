using UnityEngine;

/// <summary>
/// 攻擊系統：遠距離
/// 繼承語法：子類別：要繼承的類別(父類別)
/// 擁有父類別的成員：欄位、屬性、方法、事件
/// </summary>
public class AttackSystemFar : AttackSystem
{
    [Header("生成粒子位置")]
    public Transform positionSpawn;
    [Header("攻擊粒子")]
    public GameObject goAttackPartical;
    [Header("粒子發射速度"), Range(0, 1500)]
    public float speed = 500;

    // override 複寫：複寫父類別 virtual 成員
    public override void Attack()
    {
        // base.Attack();      // base 基底：父類別的內容

        print("遠攻擊");

        // 生成(物件，座標，角度)
        // 生成的物件名稱後方會有(clone)
        // Quaternion 四元數
        // identity 零角度
        GameObject tempAttack = Instantiate(goAttackPartical, positionSpawn.position, Quaternion.identity);
        tempAttack.GetComponent<Rigidbody2D>();
        // 添加元件<子彈系統>().攻擊力 = 此攻擊系統攻擊力
        tempAttack.AddComponent<Bullet>().attack = attack;
    }
}
