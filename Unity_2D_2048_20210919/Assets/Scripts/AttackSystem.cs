using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections;

public class AttackSystem : MonoBehaviour
{
    #region ���G���}
    [Header("�����O��")]
    public float attack = 1;
    [Header("�����ؼ�")]
    public GameObject goTarget;
    [Header("�����O����")]
    public Text textAttack;
    [Header("�������"), Range(0, 10)]
    public float delayAttack = 2f;
    [Header("����ǰe�ˮ`"), Range(0, 5)]
    public float delaySendDamage = 0.5f;
    [Header("�ʵe�Ѽ�")]
    public string parameterAttack = "����Ĳ�o";
    #endregion

    #region ���G�O�@ protected
    // public ���\�������O�s��
    // private ���\�����O�s��
    // protected ���\�l���O�s��
    protected HealthSystem targetHealthSystem;
    protected Animator ani;
    #endregion

    #region �ƥ�
    private void Awake()
    {
        textAttack.text = "Atk" + attack;
        ani = GetComponent<Animator>();
        targetHealthSystem = goTarget.GetComponent<HealthSystem>();
    }
    #endregion

    [Header("���������ƥ�")]
    public UnityEvent onAttackfinsh;

    #region ��k�G���}
    // virtual �����G���\�l���O�Ƽg
    /// <summary>
    /// ������k
    /// </summary>
    public virtual void Attack()
    {
        print("�o�ʧ����B�����O���G" + attack);
        ani.SetTrigger(parameterAttack);
    }

    private IEnumerator DrelatAttack()
    {
        // ���ݩ���3.5�����
        yield return new WaitForSeconds(delayAttack);
        // �����ʵe
        ani.SetTrigger(parameterAttack);
        // ����0.5��
        yield return new WaitForSeconds(delaySendDamage);
        // �ǰe�ˮ`
        targetHealthSystem.Hurt(attack);
        onAttackfinsh.Invoke();
    }
    #endregion
}
