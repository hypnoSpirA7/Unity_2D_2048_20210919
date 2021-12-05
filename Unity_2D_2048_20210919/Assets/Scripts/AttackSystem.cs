using UnityEngine;

public class AttackSystem : MonoBehaviour
{
    #region 欄位：公開
    [Header("攻擊力基底")]
    public float attack = 1;
    [Header("攻擊目標")]
    public GameObject goTarget;
    #endregion

    #region 方法：公開
    /// <summary>
    /// 攻擊方法
    /// </summary>
    public void Attack()
    {
        print("發動攻擊、攻擊力為：" + attack);
    }
    #endregion
}
