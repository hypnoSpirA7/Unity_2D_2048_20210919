using UnityEngine;

/// <summary>
/// summery 摘要
/// 資料說明，顯示在VS編譯器上
/// </summary>
public class LearnMethod : MonoBehaviour
{
    // 方法 Method、Function(函式)
    // 作用：執行較複雜的程式內容
    // 語法：
    // 修飾詞 傳回資料類型 方法名稱 (參數) {程式內容}
    // 無傳回 void
    // 命名習慣：Unity方法以大寫開頭
    // 自訂方法 ：不會執行
    public void Test()
    {
        print("我是測試方法");
    }
    public void Start()
    {
        // 呼叫方法
        // 方法名稱()
        Test();
        Drive90();
        Drive150();
        // 呼叫方法：引數
        Drive(70);
        Drive(200);
    }

    // 企劃需求
    // 撥放音效
    // 汽車可以加速，時速為90
    // 汽車可以加速，時速為150
    public void Drive90()
    {
        print("開車，時速:" + 90);
        print("音效");
    }

    public void Drive150()
    {
        print("開車，時速:" + 150);
        print("音效");
    }

    // 定義方法
    // 參數：資料類型 參數名稱
    public void Drive(int speed)
    {
        print("開車，時速:" + speed);
        print("音效");
    }
}
