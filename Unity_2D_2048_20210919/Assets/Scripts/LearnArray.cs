using UnityEngine;

public class LearnArray : MonoBehaviour
{
    // ���Ӿǥͪ�����"�¤�k"
    public int score1 = 100;
    public int score2 = 100;
    public int score3 = 100;
    public int score4 = 100;
    public int score5 = 100;

    // �������[] - �}�C�������
    // �}�C : �x�s�ۦP�������
    public int[] scores;
    // �w�q�w���ƶq���}�C
    public float[] attacks = new float[3];
    // �w�q�]�t�Ȫ��}�C
    public string[] props = {"����","�Ť�","�}��"};
    
    

    private void Start()
    {
        score3 = 60;

        // �s���}�C���
        // ���o�}�C���
        // �y�k : �}�C�W��[�s��] - �s���q�s�}�l
        print("�ĤT�ӹD��:" + props[2]);
        // print("�ĤT�ӹD��:"+props[3]); // OutOfRange �W�X�d��
        // �]�w�}�C���
        // �y�k : �}�C�W��[�s��] ���w ��;
        props[0] = "����";

        // �}�C�ƶq Length
        print("�D�㪺�ƶq:" + props.Length);

        // �Q�ΰj��]�w�}�C�� : 10 ~ 50
        for (int i = 0; i < scores.Length; i++) 
        {
            scores[i] = i * 10 + 10;
        }
    }
}
