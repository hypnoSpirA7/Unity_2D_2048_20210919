using UnityEngine;

public class LearnPropertyStatic : MonoBehaviour
{
    private void Start()
    {
        // �R�A�ݩ� Static Property
        // ���o�R�A�ݩ�
        // �y�k : ���O�W��.�R�A�ݩʦW��
        print("�H����:" + Random.value);
        print("��v���ƶq" + Camera.allCamerasCount);

        // �]�w�R�A�ݩ�
        Cursor.visible = false;
        // Mathf.PI = 9.999999f; "���i����" // (Read Only) �߿W ����]�w
    }
}
