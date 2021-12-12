using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections;

public class AttackSystem : MonoBehaviour
{
    #region 欄位：公開
    [Header("攻擊力基底")]
    public float attack = 1;
    [Header("攻擊目標")]
    public GameObject goTarget;
    [Header("攻擊力介面")]
    public Text textAttack;
    [Header("延遲攻擊"), Range(0, 10)]
    public float delayAttack = 2f;
    [Header("延遲傳送傷害"), Range(0, 5)]
    public float delaySendDamage = 0.5f;
    [Header("動畫參數")]
    public string parameterAttack = "攻擊觸發";
    #endregion

    #region 欄位：保護 protected
    // public 允許任何類別存取
    // private 允許此類別存取
    // protected 允許子類別存取
    protected HealthSystem targetHealthSystem;
    protected Animator ani;
    #endregion

    #region 事件
    private void Awake()
    {
        textAttack.text = "Atk" + attack;
        ani = GetComponent<Animator>();
        targetHealthSystem = goTarget.GetComponent<HealthSystem>();
    }
    #endregion

    [Header("攻擊完成事件")]
    public UnityEvent onAttackfinsh;

    #region 方法：公開
    // virtual 虛擬：允許子類別複寫
    /// <summary>
    /// 攻擊方法
    /// </summary>
    public virtual void Attack()
    {
        print("發動攻擊、攻擊力為：" + attack);
        ani.SetTrigger(parameterAttack);
    }

    private IEnumerator DrelatAttack()
    {
        // 等待延遲3.5秒攻擊
        yield return new WaitForSeconds(delayAttack);
        // 攻擊動畫
        ani.SetTrigger(parameterAttack);
        // 延遲0.5秒
        yield return new WaitForSeconds(delaySendDamage);
        // 傳送傷害
        targetHealthSystem.Hurt(attack);
        onAttackfinsh.Invoke();
    }
    #endregion
}
