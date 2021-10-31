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

    private void Start()
    {
        // 呼叫方法
        // 方法名稱()
        Test();
        Drive90();
        Drive150();
        // 呼叫方法：引數
        // 有預設值的參數可以不用填寫，使用預設值
        Drive(70, "(｡∀ﾟ)");
        Drive(200, "(｡Aﾟ)");
        Drive(300);
        // 時速 50，預設音效，石頭
        // 指定預設值參數語法 參數名稱 冒號 值
        Drive(50, effect: "石頭");

        int t = Ten();
        print("傳回方法值:" + t);

        print("不使用變數儲存傳回值:" + Ten());

        int damage = Damage(90, 30);
        print("90攻擊力與30防禦力的傷害:" + damage);
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
    // 參數：資料類型 參數名稱(指定 預設值)
    // 參數1,參數2,............參數N  
    public void Drive(int speed, string sound = "(｡Xﾟ)", string effect = "沙塵")
    {
        print("開車，時速:" + speed);
        print("音效:"+sound);
        print("特效:" + effect);

    }

    // 有回傳類型方法必須使用 return
    public int Ten()
    {
        return 10;
    }

    // !!!非必要但這很重要!!!
    // 90 - 30 = 60
    /// <summary>
    /// 傷害公式，攻擊力-防禦力=傷害值
    /// </summary>
    /// <param name="attack">攻擊力</param>
    /// <param name="defence">防禦力</param>
    /// <returns>傷害值</returns>
    public int Damage(int attack, int defence)
    {
        return attack - defence;
    }
}
