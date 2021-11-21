using UnityEngine;
using System.Linq;

/// <summary>
/// 2048�t��
/// �x�s�C�Ӱ϶����
/// �޲z�H���ͦ�
/// �ưʱ���
/// �Ʀr�X�֧P�w
/// �C������P�w
/// </summary>
public class System2048 : MonoBehaviour
{
    [Header("�ťհ϶�")]
    public Transform[] blocksEmpty;
    [Header("�Ʀr�϶�")]
    public GameObject goNumberBlock;
    [Header("�e�� 2048")]
    public Transform traCanvas2048;

    // �p�H��ܦb�ݩʭ��O�W
    [SerializeField]
    private Direction direction;

    /// <summary>
    /// �Ҧ��϶����
    /// </summary>
    public BlockData[,] blocks = new BlockData[4, 4];

    private void Start()
    {
        Initialize();
    }

    /// <summary>
    /// ��l�Ƹ��
    /// </summary>
    private void Initialize()
    {
        for (int i = 0; i < blocks.GetLength(0); i++)
        {
            for (int j = 0; j < blocks.GetLength(1); j++)
            {
                blocks[i, j] = new BlockData();
                blocks[i, j].v2Index = new Vector2Int(i, j);
                blocks[i, j].v2Position = blocksEmpty[i * blocks.GetLength(1) + j].position;
            }
        }

        PrintBlockData();
        CreateRandomNumberBlock();
        CreateRandomNumberBlock();
    }

    /// <summary>
    /// ��X�϶��G���}�C���
    /// </summary>
    private void PrintBlockData()
    {
        string result = "";

        for (int i = 0; i < blocks.GetLength(0); i++)
        {
            for(int j = 0; j < blocks.GetLength(1); j++)
            {
                // �s���B�Ʀr�P�y��
                // result += "�s��" + blocks[i, j].v2Index + "<color=cyan>�Ʀr�G" + blocks[i, j].number + "</color>" + blocks[i,j].v2Position + " |";
                // �s���B�Ʀr�P����
                result += "�s��" + blocks[i, j].v2Index + "<color=cyan>�Ʀr�G" + blocks[i, j].number + "</color>" + blocks[i,j].v2Position + " |";
            }

            result += "\n";
        }

        print(result);
    }

    /// <summary>
    /// �إ��H���Ʀr�϶�
    /// �P�_�Ҧ��϶����S���Ʀr���϶� - �Ʀr���s
    /// �H���D��@��
    /// �ͦ��Ʀr���Ӱ϶���
    /// </summary>
    private void CreateRandomNumberBlock()
    {
        var equalZero =
            from BlockData data in blocks
            where data.number == 0
            select data;

        print("���s����Ʀ��X���G" + equalZero.Count());

        int randomIndex = Random.Range(0, equalZero.Count());
        print("�H���s�� �G" + randomIndex);

        // ��X�H���϶� �s��
        BlockData select = equalZero.ToArray()[randomIndex];
        BlockData dataRandom = blocks[select.v2Index.x, select.v2Index.y];
        // �N�Ʀr 2 ��J���H���϶���
        dataRandom.number = 2;

        PrintBlockData();

        // ��Ҥ� - �ͦ�(����A������)
        GameObject tempBlock = Instantiate(goNumberBlock, traCanvas2048);
        tempBlock.transform.position = dataRandom.v2Position;
        dataRandom.goBlock = tempBlock;
    }
}

    /// <summary>
    /// �϶����
    /// �C�Ӱ϶��C������B�y�СB�s���B�Ʀr
    /// </summary>
    public class BlockData
{
    /// <summary>
    /// �϶������Ʀr����
    /// </summary>
    public GameObject goBlock;
    /// <summary>
    /// �϶��y��
    /// </summary>
    public Vector2 v2Position;
    /// <summary>
    /// �϶��s���G�G���}�C�����s��
    /// </summary>
    public Vector2Int v2Index;
    /// <summary>
    /// �϶��Ʀr�G�w�]�� 0�A�Ϊ� 2�B4�B8�B16....2048
    /// </summary>
    public int number;
}

/// <summary>
/// ��V�C�|�G�L�B���B�k�B�W�B�U
/// </summary>
public enum Direction
{
    None,Left,Right,Up,Down
}