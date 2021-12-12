using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 血量系統
/// 管理血量、受傷與死亡
/// </summary>
public class HealthSystem : MonoBehaviour
{
    [Header("血量"), Range(0, 500)]
    public float hp = 1000;
    [Header("要控制的血條")]
    public Text textHp;
    public Image imghp;
    [Header("造成傷害的物件標籤")]
    public string tagDamageObject;
    [Header("動畫參數")]
    public string parameterDamage = "吸貓_受傷";
    public string parameterDead = "吸貓_倒地";


    private float hpMax;
    private Animator ani;

    // 喚醒事件：在Start之前執行一次，處理初始值
    private void Awake()
    {
        hpMax = hp;
        ani = GetComponent<Animator>();
    }

    private void Start()
    {
        textHp.text = "HP" + hp;
        imghp.fillAmount = 1;
    }


    // 碰撞事件：兩個碰撞器其中一個有勾選is trigger
    // Enter 碰撞開始時執行此事件一次
    // collision 碰到物件得碰撞資訊
    private void OnTriggerStay2D(Collider2D collision)
    {
        // 如果 碰到的標籤 是 造成傷害物件標籤
        if (collision.tag == tagDamageObject) 
        {
            Hurt(collision.GetComponent<Bullet>().attack);
        }
    }

    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="damage">接收到的傷害</param>
    public void Hurt(float damage)
    {
        if (hp <= 0) return;                            // 如果死亡就退出

        hp -= damage;
        hp = Mathf.Clamp(hp, 0, hpMax);                 // 夾住(hp，最小，最大)
        textHp.text = "HP" + hp;
        imghp.fillAmount = hp / hpMax;
        ani.SetTrigger(parameterDamage);
        if (hp <= 0) Dead();
    }

    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {
        ani.SetTrigger(parameterDead);
    }
}
