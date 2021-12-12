using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ��q�t��
/// �޲z��q�B���˻P���`
/// </summary>
public class HealthSystem : MonoBehaviour
{
    [Header("��q"), Range(0, 500)]
    public float hp = 1000;
    [Header("�n������")]
    public Text textHp;
    public Image imghp;
    [Header("�y���ˮ`���������")]
    public string tagDamageObject;
    [Header("�ʵe�Ѽ�")]
    public string parameterDamage = "�l��_����";
    public string parameterDead = "�l��_�˦a";


    private float hpMax;
    private Animator ani;

    // ����ƥ�G�bStart���e����@���A�B�z��l��
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


    // �I���ƥ�G��ӸI�����䤤�@�Ӧ��Ŀ�is trigger
    // Enter �I���}�l�ɰ��榹�ƥ�@��
    // collision �I�쪫��o�I����T
    private void OnTriggerStay2D(Collider2D collision)
    {
        // �p�G �I�쪺���� �O �y���ˮ`�������
        if (collision.tag == tagDamageObject) 
        {
            Hurt(collision.GetComponent<Bullet>().attack);
        }
    }

    /// <summary>
    /// ����
    /// </summary>
    /// <param name="damage">�����쪺�ˮ`</param>
    public void Hurt(float damage)
    {
        if (hp <= 0) return;                            // �p�G���`�N�h�X

        hp -= damage;
        hp = Mathf.Clamp(hp, 0, hpMax);                 // ����(hp�A�̤p�A�̤j)
        textHp.text = "HP" + hp;
        imghp.fillAmount = hp / hpMax;
        ani.SetTrigger(parameterDamage);
        if (hp <= 0) Dead();
    }

    /// <summary>
    /// ���`
    /// </summary>
    private void Dead()
    {
        ani.SetTrigger(parameterDead);
    }
}
