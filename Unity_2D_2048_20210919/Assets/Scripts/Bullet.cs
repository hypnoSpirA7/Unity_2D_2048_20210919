using UnityEngine;

public class Bullet : MonoBehaviour
{
    /// <summary>
    /// 發射者的攻擊力
    /// </summary>
    public float attack;

    private bool isHit;

    private void Awake()
    {
        Physics2D.IgnoreLayerCollision(3, 3, true);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        // gameObject 指此腳本的遊戲物件
        // Destroy() 刪除物件
        if (collision.gameObject.name.Contains("吸貓") && !isHit)
        {
            isHit = true;
            tag = "Untagged";
            Destroy(gameObject, 0.1f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("吸貓")) GetComponent<Collider2D>().isTrigger = true;
    }

}
