using UnityEngine;

/// <summary>
/// 學習靜態方法
/// </summary>
public class LearnMethodStatic : MonoBehaviour
{
    private void Start()
    {
        // 靜態方法
        // 呼叫靜態方法語法:
        // 類別名稱.靜態方法名稱(對應的引數);
        float r = Random.Range(0f, 0.99f);
        print("隨機範圍 0 ~ 0.99:" + r);
        // 有多個 Declaration 代表此方法有"多載方法":多種呼叫方式
        int rInt = Random.Range(0, 3); // 0,1,2
        print("隨機整數 1~2:" + rInt);
    }

    private void Update()
    {
        bool space = Input.GetKeyDown(KeyCode.Space);
        print("玩家是否按空白建:" + space);
    }
}
