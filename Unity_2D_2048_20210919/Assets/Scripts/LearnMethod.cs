using UnityEngine;

/// <summary>
/// summery �K�n
/// ��ƻ����A��ܦbVS�sĶ���W
/// </summary>
public class LearnMethod : MonoBehaviour
{
    // ��k Method�BFunction(�禡)
    // �@�ΡG������������{�����e
    // �y�k�G
    // �׹��� �Ǧ^������� ��k�W�� (�Ѽ�) {�{�����e}
    // �L�Ǧ^ void
    // �R�W�ߺD�GUnity��k�H�j�g�}�Y
    // �ۭq��k �G���|����
    public void Test()
    {
        print("�ڬO���դ�k");
    }
    public void Start()
    {
        // �I�s��k
        // ��k�W��()
        Test();
        Drive90();
        Drive150();
        // �I�s��k�G�޼�
        Drive(70);
        Drive(200);
    }

    // �����ݨD
    // ���񭵮�
    // �T���i�H�[�t�A�ɳt��90
    // �T���i�H�[�t�A�ɳt��150
    public void Drive90()
    {
        print("�}���A�ɳt:" + 90);
        print("����");
    }

    public void Drive150()
    {
        print("�}���A�ɳt:" + 150);
        print("����");
    }

    // �w�q��k
    // �ѼơG������� �ѼƦW��
    public void Drive(int speed)
    {
        print("�}���A�ɳt:" + speed);
        print("����");
    }
}
