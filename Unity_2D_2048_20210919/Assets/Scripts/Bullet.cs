using UnityEngine;

/// <summary>
/// �l�u�t��
/// ��a�o�g�̪������O
/// �B�z�I����R������
/// </summary>
public class Bullet : MonoBehaviour
{
    /// <summary>
    /// �o�g�̪������O
    /// </summary>
    public float attack;

    private void Awake()
    {
        Physics2D.IgnoreLayerCollision(3, 3);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // gameObject �����}�����C������
        // Destroy() �R������
        Destroy(gameObject);
    }
}