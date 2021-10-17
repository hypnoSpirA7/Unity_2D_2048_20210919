//  單行註解：說明文字，不會執行@#
//  功能 2021.10.17
//  開發者 hypnoSpirA 2021.10.17
using UnityEngine;// 引用 Unity Engine API

//  class 類別(藍圖) 名稱與檔名必須完全相同
public class Car : MonoBehaviour
{
    #region 欄位語法與四大基本類型
    //  認識欄位(Field)，儲存資料
    //  語法：修飾詞 欄位類型 欄位名稱 結束符號
    //  常用四大資料類型
    //  1.整數(int)       沒有小數點的正負整數  預設值=0
    //  2.浮點數(float)   有小數點的正負數      預設值=0
    //  3.字串(string)    文字資訊             預設值=空
    //  4.布林直(bool)    是與否(true/false)   預設值=false
    //  修飾詞
    //  公開 所有類別可存取
    //  私人 縣此類別可存取

    //  欄位屬性 Attritube
    //  語法：[屬性名稱(數值)"解說"]
    //  1.標題Header(字串)
    //  2.提示Tooltip(字串)
    //  3.範圍 Range (float,float)
    [Header("汽車CC數")]
    [Range(1000, 5000)]
    public int cc = 2000;
    [Tooltip("車體重，範圍1-12"), Range(1, 12)]
    public float weight = 3.5f;
    public string brand = "BenZ";
    public bool hasSunRoof = true;
    #endregion

    #region 遊戲內常用資料類型
    //  顏色 Color
    public Color color1;
    public Color colorRed = Color.red;
    public Color colorCustom = new Color(0, 0, 1);
    public Color colorCustomAlpga = new Color(0, 1, 0, 0.3f);
    //  向量座標 Vector
    //  Vector 2-4
    public Vector2 v2;
    public Vector2 v2One = Vector2.one;
    public Vector2 v2Up = Vector2.up;
    public Vector2 v2Custom = new Vector2(7, 9);
    public Vector3 v3Custom = new Vector3(1, 2, 3);
    public Vector4 v4Custom = new Vector4(1, 2, 3, 4);
    //  按鍵 KeyCode
    public KeyCode kc;
    public KeyCode kcW = KeyCode.W;
    public KeyCode kcML = KeyCode.Mouse0;

    //  遊戲物件 GameObject 不須指定預設值
    public GameObject catStand;
    public GameObject catSit;
    //  元件 Component 不須指定預設值
    public Transform traBox;
    public SpriteRenderer sprBox;
    public Camera cam;
    #endregion

    #region 存取欄位資料 Set Get

    // 程式入口：事件
    // 開始事件：播放遊戲時執行一次，初始設定
    private void Start()
    {
        print("Hello,World(⁰▽o)");

        //  取得 Get 欄位資料 !預設值以屬性面板為主!(Inspector)
        //  語法：欄位名稱
        print("cc數:" + cc);
        print(weight);

        //  存放 Set 欄位資料
        //  語法：欄位名稱 指定 值;
        brand = "MAZDA";
        cc = 3500;
    }
    #endregion
}
