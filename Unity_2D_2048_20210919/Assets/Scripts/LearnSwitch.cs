using UnityEngine;

/// <summary>
/// 判斷式 switch
/// </summary>
public class LearnSwitch : MonoBehaviour
{
    public string equipment;

    private void Start()
    {
        // Switch 語法:
        // switch (要判斷的資料)
        // {
        //      case 值 1:
        //          程式內容;
        //          break;
        //      case 值 2:
        //          程式內容;
        //          break;
        //      default:            // 當資料不符合上面的case "可省略"
        //          程式內容;
        //          break;
        // }

        switch (equipment)
        {
            case "刀子":
                print("裝備刀子");
                break;
            case "湯匙":
                print("裝備湯匙");
                break;
            default:
                print("給我去拿武器");
                break;
        }
    }
}
