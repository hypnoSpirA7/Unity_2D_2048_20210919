using UnityEngine;

public class LearnProperty : MonoBehaviour
{
    // ���
    public int passwordField = 123456789;

    // �ݩ�
    // �y�k
    // �׹��� ������� �ݩʦW�� {�s���l}
    public int passwordProperty { get; set; }
    // get ���o
    // set �]�w
    // �߿W�ݩ� �u����o
    // =>Lambda �H�ڹF c# 6.0
    public int myPasswordProperty { get =>999; }

    // ��Ū����g�k
    // get �ݨϥ�����r return �Ǧ^
    public string nameCharacter
    {
        get
        {
            print("�ڦb�ݩ� name Character �̭�");
            return "KID";
        }
    }
    // �߼g����g�k
    // set �ϥ�����r value ��J��
    public float attack
    {
        set
        {
            print("�����O" + value);
        }

    }

    // �}�l�]�w�G����ɰ���@��(Start)
    private void Start()
    {
        // �y�k �ݩʭ�
        // �y�k�G
        // �ݩʦW�� ���w �ȡF
        passwordProperty = 777;
        // ���o Get �ݩʸ��
        // �y�k�G
        // �ݩʦW��
        print("�ݩʱK�X�G" + passwordProperty);

        // myPasswordProperty = 999; // ���A�� �߿W�ݩ�
        print("�ڪ��ݩʱK�X�G" + myPasswordProperty);

        print(nameCharacter);

        // print(attack);       // ������o �߼g�ݩ�
        attack = 99.9f;
    }

}
