using UnityEngine;

public class Bullet : MonoBehaviour
{
    /// <summary>
    /// �o�g�̪������O
    /// </summary>
    public float attack;

    private bool isHit;

    private void Awake()
    {
        Physics2D.IgnoreLayerCollision(3, 3, true);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        // gameObject �����}�����C������
        // Destroy() �R������
        if (collision.gameObject.name.Contains("�l��") && !isHit)
        {
            isHit = true;
            tag = "Untagged";
            Destroy(gameObject, 0.1f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("�l��")) GetComponent<Collider2D>().isTrigger = true;
    }

}
