using UnityEngine;

/// <summary>
/// �{�ѹB��l
/// 1.���w
/// 2.�ƾ�
/// 3.���
/// 4.�޿�
/// </summary>
public class LearnOperator : MonoBehaviour
{
    public float a = 10;
    public float b = 3;
    public int c = 30;
    public int hp = 100;

    private void Start()
    {
        #region ���w�B��l
        // ���w =
        // ��������w�B��l"�k��"����w��"����"
        #endregion

        #region �ƾǹB��l
        // �[�k"+"
        print("�[�k:" + (a + b));     // ���G 13
        // ��k"-"
        print("��k:" + (a - b));     // ���G 7
        // ���k"*"
        print("���k:" + (a * b));     // ���G 30
        // ���k"/"
        print("���k:" + (a / b));     // ���G 3.33333333
        // �l��"%"
        print("�l��:" + (a % b));     // ���G 3�l1

        c = c + 1;                   // ��l�g�k
        print("C ���G:" + c);
        c++;
        print("C ���G:" + c);

        hp = hp + 10;
        print("HP ���G:" + hp);
        hp += 10;                    //�A�μƾǹB��l += -= *= /= %=
        print("HP���G:" + hp);
        #endregion

        #region ����B��l
        // �����ӭ�,�åB�o�쥬�L�ȵ��G
        // �j��">"
        print("a > b" + (a > b));       // T
        // �p��"<"
        print("a < b" + (a < b));       // F
        // �j�󵥩�">="
        print("a >= b" + (a >= b));     // T
        // �p�󵥩�"<="
        print("a <= b" + (a <= b));     // F
        // ����"=="
        print("a == b" + (a == b));     // F
        // ������"!="
        print("a != b" + (a != b));     // T
        #endregion

        #region �޿�B��l
        // �����Ӥ��L��,�åB�o�쥬�L�ȵ��G
        // �åB"&&":�u�n���@�� f ���G�N�O f
        print("t && t " + (true && true));           //T
        print("f && t " + (false && true));          //F
        print("t && f " + (true && false));          //F
        print("f && f " + (false && false));         //F
        // �Ϊ�"||":�u�n���@�� t ���G�N�O t
        print("t || t " + (true || true));           //T
        print("f || t " + (false || true));          //T
        print("t || f " + (true || false));          //T
        print("f || f " + (false || false));         //F
        // �A��"!":�u��[�b���L�ȫe��
        print(!true);                                //T->F
        print(!(a > b));                             //T->F
        print(!(true && true));                      //T->F
        // Alt+Shift+>=�ֳt���
        #endregion
    }
}
