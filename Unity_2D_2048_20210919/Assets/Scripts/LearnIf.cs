using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public bool openDoor;
    public int score = 99;

    private void Start()
    {
        // �P�_�� if
        // �y�k:�p�G(���L��){���L�� �� true �|���� �{�����e}
        // �_�h {���L�� �� false �|���� �{�����e}
        if (true)
        {
            print("���L�� true");
        }
        if (false)
        {
            print("���L�� true");
        }

        // openDoor == true �P openDoor �ĪG�ۦP
        if (openDoor)
        {
            print("�}��");
        }
        else
        {
            print("����");
        }
    }

    private void Update()
    {


        // �p�G���� > 60    �ή�
        if (score >= 60)
        {
            print("�ή�");
        }
        // �p�G���� >= 40   �ɦ�
        // �y�k:else if (���L��) { ���L�� �� true �ɰ��� }
        // else if ��b if �U��P else �W�� �i�H�L����m
        else if (score >= 40)
        {
            print("�ɦ�");
        }
        // �p�G���� < 40    ����
        else
        {
            print("����");
        }
    }
}
