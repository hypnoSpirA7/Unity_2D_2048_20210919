using UnityEngine;

public class AttackSystem : MonoBehaviour
{
    #region ���G���}
    [Header("�����O��")]
    public float attack = 1;
    [Header("�����ؼ�")]
    public GameObject goTarget;
    #endregion

    #region ��k�G���}
    /// <summary>
    /// ������k
    /// </summary>
    public void Attack()
    {
        print("�o�ʧ����B�����O���G" + attack);
    }
    #endregion
}
