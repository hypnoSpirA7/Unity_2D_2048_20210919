using UnityEngine;

/// <summary>
/// �����t�ΡG���Z��
/// �~�ӻy�k�G�l���O�G�n�~�Ӫ����O(�����O)
/// �֦������O�������G���B�ݩʡB��k�B�ƥ�
/// </summary>
public class AttackSystemFar : AttackSystem
{
    [Header("�ͦ��ɤl��m")]
    public Transform positionSpawn;
    [Header("�����ɤl")]
    public GameObject goAttackPartical;
    [Header("�ɤl�o�g�t��"), Range(0, 1500)]
    public float speed = 500;

    // override �Ƽg�G�Ƽg�����O virtual ����
    public override void Attack()
    {
        // base.Attack();      // base �򩳡G�����O�����e

        print("������");

        // �ͦ�(����A�y�СA����)
        // �ͦ�������W�٫��|��(clone)
        // Quaternion �|����
        // identity �s����
        GameObject tempAttack = Instantiate(goAttackPartical, positionSpawn.position, Quaternion.identity);
        tempAttack.GetComponent<Rigidbody2D>();
        // �K�[����<�l�u�t��>().�����O = �������t�Χ����O
        tempAttack.AddComponent<Bullet>().attack = attack;
    }
}
