using UnityEngine;
using System.Linq;  // LinQ Query 查詢語言 - 資料查詢
using System.Globalization;

/// <summary>
/// 認識二維陣列
/// </summary>
public class Learn2DArray : MonoBehaviour
{
    // 一維陣列
    public int[] numbers = { 2, 4, 8, 16, 32 };
    // 二維陣列：不會顯示 - 套裝件 Odin 自己寫 Editor
    public int[,] blocks = { { 2, 4 }, { 8, 16 } };

    public string[,] objects = new string[4, 6];

    public int[,] scores = { { 2, 4 }, { 8, 16 }, { 32, 64 } };

    private void Start()
    {
        #region 存取
        // 一維陣列存取
        numbers[4] = 99;
        print("一維陣列第五筆資料 ：" + numbers[4]);

        // 二維陣列存取
        print("二維陣列第二列第一欄 1, 0 : " + blocks[1, 0]);
        blocks[1, 0] = 7;
        print("二維陣列第二列第一欄 1, 0 : " + blocks[ 1, 0]);

        print("二維陣列第一維度長度 : " + scores.GetLength(0));
        print("二維陣列第二維度長度 : " + scores.GetLength(1));

        string result = "";

        for (int i = 0; i < scores.GetLength(0); i++)
        {
            for (int j = 0; j < scores.GetLength(1); j++)
            {
                result += scores[i, j] + " | ";
            }

            result += "\n";
        }

        print(result);
        #endregion

        #region 資料搜尋

        // 搜尋 numbers 一維陣列內大於等於 10 的資料
        // var 無類型資料型態
        // from 資料A in 陣列       - 從陣列搜尋資料並保存為 資料A
        // where 資料A 條件         - 判斷 資料A 是否符合條件
        // select 資料A；           - 選取 符合條件的資料A
        var numberGratgerTen =
           from int n in numbers
           where n >= 10
           select n;

        print("符合 >= 10資料有幾筆 ：" + numberGratgerTen.Count());

        for (int i = 0; i < numberGratgerTen.Count(); i++)
        {
            print(">= 10的資料為：" + numberGratgerTen.ToArray()[i]);
        }

        // scores 低於20有哪些
        var noPass =
            from int no in scores
            where no < 20
            select no;

        for (int i = 0; i < noPass.Count(); i++)
        {
            print("低於20的數：" + noPass.ToArray()[i]);
        }
        #endregion
    }

}
