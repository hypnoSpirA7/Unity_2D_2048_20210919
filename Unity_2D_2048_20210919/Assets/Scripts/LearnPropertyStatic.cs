using UnityEngine;

public class LearnPropertyStatic : MonoBehaviour
{
    private void Start()
    {
        // 靜態屬性 Static Property
        // 取得靜態屬性
        // 語法 : 類別名稱.靜態屬性名稱
        print("隨機值:" + Random.value);
        print("攝影機數量" + Camera.allCamerasCount);

        // 設定靜態屬性
        Cursor.visible = false;
        // Mathf.PI = 9.999999f; "不可改變" // (Read Only) 唯獨 不能設定
    }
}
