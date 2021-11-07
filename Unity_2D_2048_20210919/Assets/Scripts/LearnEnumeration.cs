using UnityEngine;

/// <summary>
/// 列舉:下拉式選單
/// </summary>
public class LearnEnumeration : MonoBehaviour
{
    // 1. 定義列舉
    // 語法: 修飾詞 列舉 列舉名稱{列舉.1,列舉.2.....列舉N}
    public enum StateEnemy
    {
        Idle, Walk, Track, Attack, Dead
    }
    // 2. 使用列舉
    // 語法 : 修飾詞 列舉名稱 欄位名稱 指定 值;
    public StateEnemy state;

    private void Update()
    {
        switch (state)
        {
            case StateEnemy.Idle:
                print("等待");
                print("特效");
                print("動畫");
                break;
            case StateEnemy.Walk:
                print("走路");
                break;
            case StateEnemy.Track:
                print("追蹤中");
                break;
            case StateEnemy.Attack:
                print("攻擊");
                break;
            case StateEnemy.Dead:
                print("死亡");
                break;
        }
    }
}
