using UnityEngine;

public class LearnLoop : MonoBehaviour
{
    private void Start()
    {
        // ��X�Ʀr 1 ~ 5 "�¤�k"
        print("�Ʀr:" + 1);
        print("�Ʀr:" + 2);
        print("�Ʀr:" + 3);
        print("�Ʀr:" + 4);
        print("�Ʀr:" + 5);

        // �j�� : ���ư���
        // while �j��y�k :
        // while (���L��) { ���L�� = true �|������� ���쥬�L�Ȭ� false �{�����e }
        int number = 1;

        // �� �Ʀr �p�� 6 �|����...
        while (number < 6)
        {
            print("while �j��Ʀr : " + number);
            number++;
        }

        // for (��l�� ; ���L�� ; �j�鵲������{���ԭz)
        for (int x = 1; x < 6; x++)
        {
            print("for �j��Ʀr:" + x);
        }
    }
}
