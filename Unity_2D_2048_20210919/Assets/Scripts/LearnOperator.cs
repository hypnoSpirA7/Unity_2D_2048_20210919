using UnityEngine;

/// <summary>
/// 認識運算子
/// 1.指定
/// 2.數學
/// 3.比較
/// 4.邏輯
/// </summary>
public class LearnOperator : MonoBehaviour
{
    public float a = 10;
    public float b = 3;
    public int c = 30;
    public int hp = 100;

    private void Start()
    {
        #region 指定運算子
        // 指定 =
        // 先執行指定運算子"右邊"後指定給"左邊"
        #endregion

        #region 數學運算子
        // 加法"+"
        print("加法:" + (a + b));     // 結果 13
        // 減法"-"
        print("減法:" + (a - b));     // 結果 7
        // 乘法"*"
        print("乘法:" + (a * b));     // 結果 30
        // 除法"/"
        print("除法:" + (a / b));     // 結果 3.33333333
        // 餘數"%"
        print("餘數:" + (a % b));     // 結果 3餘1

        c = c + 1;                   // 原始寫法
        print("C 結果:" + c);
        c++;
        print("C 結果:" + c);

        hp = hp + 10;
        print("HP 結果:" + hp);
        hp += 10;                    //適用數學運算子 += -= *= /= %=
        print("HP結果:" + hp);
        #endregion

        #region 比較運算子
        // 比較兩個值,並且得到布林值結果
        // 大於">"
        print("a > b" + (a > b));       // T
        // 小於"<"
        print("a < b" + (a < b));       // F
        // 大於等於">="
        print("a >= b" + (a >= b));     // T
        // 小於等於"<="
        print("a <= b" + (a <= b));     // F
        // 等於"=="
        print("a == b" + (a == b));     // F
        // 不等於"!="
        print("a != b" + (a != b));     // T
        #endregion

        #region 邏輯運算子
        // 比較兩個不林值,並且得到布林值結果
        // 並且"&&":只要有一個 f 結果就是 f
        print("t && t " + (true && true));           //T
        print("f && t " + (false && true));          //F
        print("t && f " + (true && false));          //F
        print("f && f " + (false && false));         //F
        // 或者"||":只要有一個 t 結果就是 t
        print("t || t " + (true || true));           //T
        print("f || t " + (false || true));          //T
        print("t || f " + (true || false));          //T
        print("f || f " + (false || false));         //F
        // 顛倒"!":只能加在布林值前面
        print(!true);                                //T->F
        print(!(a > b));                             //T->F
        print(!(true && true));                      //T->F
        // Alt+Shift+>=快速選取
        #endregion
    }
}
