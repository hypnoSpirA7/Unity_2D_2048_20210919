using UnityEngine;

/// <summary>
/// �ǲ߫D�R�A�ݩ�,��k
/// </summary>
public class LearnPropertyNonStatic : MonoBehaviour
{
    // �R�A�P�D�R�A�t��
    // 1.�w�q���
    // 2.����������P���O
    // 3.���n�x�s����
    public Camera cam;
    public Transform tra;

    private void Start()
    {
        // �R�A��Ӳ�
        print("��v���ƶq:" + Camera.allCamerasCount);

        // �D�R�A�ݩ�
        // ���o�D�R�A�ݩʻy�k :
        // ���W��.�D�R�A�ݩʦW��
        print("��v���`��:" + cam.depth);

        // �]�w�D�R�A�ݩʻy�k:
        // ���W��.�D�R�A�ݩʦW�� ���w ��;
        tra.position = new Vector3(3, 3, 0);
    }

    private void Update()
    {
        // �I�s�D�R�A��k�y�k:
        // ���W��.�D�R�A��k�W��(�������޼�)
        tra.Translate(1, 0, 0);
    }
}
