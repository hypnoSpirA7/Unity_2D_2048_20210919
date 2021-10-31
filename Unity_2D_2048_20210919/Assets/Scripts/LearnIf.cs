using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public bool openDoor;

    private void Start()
    {
        // 判斷式 if
        // 語法:如果(布林值){當布林值 為 true 會執行 程式內容}
        // 否則 {當布林值 為 false 會執行 程式內容}
        if (true)
        {
            print("布林值 true");
        }
        if (false)
        {
            print("布林值 true");
        }

        // openDoor == true 與 openDoor 效果相同
        if (openDoor)
        {
            print("開門");
        }
        else
        {
            print("關門");
        }
    }
}
