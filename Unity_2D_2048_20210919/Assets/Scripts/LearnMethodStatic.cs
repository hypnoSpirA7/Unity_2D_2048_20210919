using UnityEngine;

/// <summary>
/// �ǲ��R�A��k
/// </summary>
public class LearnMethodStatic : MonoBehaviour
{
    private void Start()
    {
        // �R�A��k
        // �I�s�R�A��k�y�k:
        // ���O�W��.�R�A��k�W��(�������޼�);
        float r = Random.Range(0f, 0.99f);
        print("�H���d�� 0 ~ 0.99:" + r);
        // ���h�� Declaration �N����k��"�h����k":�h�ةI�s�覡
        int rInt = Random.Range(0, 3); // 0,1,2
        print("�H����� 1~2:" + rInt);
    }

    private void Update()
    {
        bool space = Input.GetKeyDown(KeyCode.Space);
        print("���a�O�_���ťի�:" + space);
    }
}
