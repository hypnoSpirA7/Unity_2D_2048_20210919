using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 遊戲管理器
/// 遊戲結束畫面控制
/// 結束畫面標題更新
/// </summary>
public class GameManager : MonoBehaviour
{
    [Header("結束畫面")]
    public GameObject goFinalCanvas;
    [Header("結束標題")]
    public Text textFinalTitale;

    public void ShowFinalCanvas(bool win)
    {
        goFinalCanvas.SetActive(true);

        // 三源運算子
        // 布林值? 布林值為 true：布林值為 false
        string title = win ? "(⁰▽o)" : "(ﾟ∀｡)";

        // 判斷式 if
        /*
        if (win) title = "win";
        else title = "Lose";
        */

        textFinalTitale.text = title;
    }
}
