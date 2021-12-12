using UnityEngine;
using System.Linq;
using UnityEngine.Events;
using UnityEngine.UI;
using JetBrains.Annotations;

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
    #region ���:���}
    [Header("�ťհ϶�")]
    public Transform[] blocksEmpty;
    [Header("�Ʀr�϶�")]
    public GameObject goNumberBlock;
    [Header("�e�� 2048")]
    public Transform traCanvas2048;
    [Header("�Ʀr�ۦP�X�֨ƥ�")]
    public UnityEvent onSameNumberCombine;
    #endregion

    #region ���:�p�H
    // �p�H�����ܦb�ݩʭ��O�W 
    [SerializeField]
    private stateTurn stateTurm;
    private Direction direction;
    /// <summary>
    /// �Ҧ��϶����
    /// </summary>
    private BlockData[,] blocks = new BlockData[4, 4];

    /// <summary>
    /// ���U�y��
    /// </summary>
    private Vector3 posDown;
    /// <summary>
    /// ��}�y��
    /// </summary>
    private Vector3 posUp;
    /// <summary>
    /// �O�_���U����
    /// </summary>
    private bool isClickMouse;
#endregion

    #region �ƥ�
    private void Start()
    {
        Initialize();
    }

    private void Update()
    {
        CheckDirection();
    }
    #endregion

    #region ��k:�p�H
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
                // �T���B��l
                // �y�k: ���L�� ? ��A : ��B;
                // ���L�Ȭ� true ���G�� �� A
                // ���L�Ȭ� false ���G�� ��B
                result += "�s��" + blocks[i, j].v2Index + "<color=cyan>�Ʀr�G" + blocks[i, j].number + "</color> <color=yellow>" + (blocks[i,j].goBlock ? "��" : "�@")+"</color> |";
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

        int randomIndex = UnityEngine.Random.Range(0, equalZero.Count());
        print("�H���s�� �G" + randomIndex);

        // ��X�H���϶� �s��
        BlockData select = equalZero.ToArray()[randomIndex];
        BlockData dataRandom = blocks[select.v2Index.x, select.v2Index.y];
        // �N�Ʀr 2 ��J���H���϶���
        dataRandom.number = 2;

        // ��Ҥ� - �ͦ�(����A������)
        GameObject tempBlock = Instantiate(goNumberBlock, traCanvas2048);
        tempBlock.transform.position = dataRandom.v2Position;
        dataRandom.goBlock = tempBlock;

        PrintBlockData();
    }

    /// <summary>
    /// �ˬd��V
    /// </summary>
    private void CheckDirection()
    {
        #region ��L
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            direction = Direction.Up;
            CheckAndMoveBlock();
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            direction = Direction.Down;
            CheckAndMoveBlock();
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction = Direction.Left;
            CheckAndMoveBlock();
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = Direction.Right;
            CheckAndMoveBlock();
        }
        #endregion

        #region �ƹ��PĲ��
        if (!isClickMouse && Input.GetKeyDown(KeyCode.Mouse0))
        {
            print("���U����");
            isClickMouse = true;
            posDown = Input.mousePosition;
            print("���U�y��:" + posDown);
        }
        else if (isClickMouse && Input.GetKeyUp(KeyCode.Mouse0))
        {
            isClickMouse = false;
            posUp = Input.mousePosition;
            print("��}����:" + posUp);

            // 1. �p��V�q�� ��}�y�� - ���U�y��
            Vector3 directionValve = posUp - posDown;
            print("�V�q��:" + directionValve);
            // 2. �ഫ��0~1��
            print("�ഫ���:" + directionValve.normalized);

            // ��V x �P Y �������
            float xAbs = Mathf.Abs(directionValve.normalized.x);
            float yAbs = Mathf.Abs(directionValve.normalized.y);
            // X > Y ������V
            if (xAbs > yAbs)
            {
                if (directionValve.normalized.x > 0) direction = Direction.Right;
                else direction = Direction.Left;
                CheckAndMoveBlock();
            }
            // Y > X ������V
            else if (yAbs > xAbs)
            {
                if (directionValve.normalized.y > 0) direction = Direction.Up;
                else direction = Direction.Down;
                CheckAndMoveBlock();
            }
        }
        #endregion
    }

    [Header("�ĤH�^�X�ƥ�")]
    public UnityEvent onEnemyTurn;

    /// <summary>
    /// �ˬd�ò��ʰ϶�
    /// </summary>
    private void CheckAndMoveBlock()
    {
        print("�ثe����V:" + direction);
        BlockData blockOriginal = new BlockData();          // ��l���Ʀr���϶�
        BlockData blockCheck = new BlockData();             // �ˬd�Ҧ����϶�
        bool canMove = false;                               // �O�_�i�H���ʰ϶�
        bool sameNumber = false;                            // �O�_�ۦP�Ʀr
        int sameNumberCount = 0;                            // �ۦP�Ʀr�X�֦���
        bool canMoveBlockAll = false;                       // �O�_�i�H���ʰ϶�

        switch (direction)
        {
            case Direction.Right:

                for (int i = 0; i < blocks.GetLength(0); i++)
                {
                    sameNumberCount = 0;                      // �ۦP�Ʀr�X�֦����k�s

                    for (int j = blocks.GetLength(1) - 2; j >= 0; j--)
                    {
                        blockOriginal = blocks[i, j];

                        // �p�G �Ӱ϶����Ʀr ���s �N �~�� (���L���j�����U�Ӱj��)
                        if (blockOriginal.number == 0) continue;

                        for (int k = j + 1; k < blocks.GetLength(1) - sameNumberCount; k++)
                        {
                            if (blocks[i, k].number == 0)
                            {
                                blockCheck = blocks[i, k];
                                canMove = true;
                            }
                            else if (blocks[i, k].number == blockOriginal.number)
                            {
                                blockCheck = blocks[i, k];
                                canMove = true;
                                sameNumber = true;
                                sameNumberCount++;
                            }
                            // �_�h �p�G �ˬd�϶� ���Ʀr �P �쥻�϶� ���Ʀr ���ۦP �N�����ʡB�Ʀr���ۦP�ä��_
                            else if (blocks[i, k].number != blockOriginal.number)
                            {
                                break;
                            }
                        }

                        // �p�G �i�H���� �b���� ���ʰ϶�(��l�B�ˬd�B�O�_�ۦP�Ʀr)
                        if (canMove)
                        {
                            canMoveBlockAll = true;                                     // �����϶����i�H����
                            canMove = false;
                            MoveBlock(blockOriginal, blockCheck, sameNumber);
                            sameNumber = false;
                        }
                    }
                }

                break;   
                
            case Direction.Left:

                for (int i = 0; i < blocks.GetLength(0); i++)
                {
                    sameNumberCount = 0;

                    for (int j = 1; j < blocks.GetLength(1); j++)
                    {
                        blockOriginal = blocks[i, j];

                        // �p�G �Ӱ϶����Ʀr ���s �N �~�� (���L���j�����U�Ӱj��)
                        if (blockOriginal.number == 0) continue;

                        for (int k = j - 1; k >= 0 + sameNumberCount; k--)
                        {
                            if (blocks[i, k].number == 0)
                            {
                                blockCheck = blocks[i,k];
                                canMove = true;
                            }
                            else if (blocks[i, k].number == blockOriginal.number)
                            {
                                blockCheck = blocks[i, k];
                                canMove = true;
                                sameNumber = true;
                                sameNumberCount++;
                            }
                            else if (blocks[i, k].number != blockOriginal.number)
                            {
                                break;
                            }
                        }

                        // �p�G �i�H���� �b���� ���ʰ϶�(��l�A�ˬd�A�O�_�ۦP�Ʀr)
                        if (canMove)
                        {
                            canMoveBlockAll = true;                                     // �����϶����i�H����
                            canMove = false;
                            MoveBlock(blockOriginal, blockCheck, sameNumber);
                            sameNumber = false;
                        }
                    }
                }
                
                break;

            case Direction.Up:

                for (int i = 0; i < blocks.GetLength(1); i++)
                {
                    sameNumberCount = 0;
                    for (int j = 1; j < blocks.GetLength(0); j++)
                    {
                        blockOriginal = blocks[j ,i];

                        // �p�G �Ӱ϶����Ʀr ���s �N �~�� (���L���j�����U�Ӱj��)
                        if (blockOriginal.number == 0) continue;

                        for (int k = j - 1; k >= 0 + sameNumberCount; k--)
                        {
                            if (blocks[k, i].number == 0)
                            {
                                blockCheck = blocks[k, i];
                                canMove = true;
                            }
                            else if (blocks[k, i].number == blockOriginal.number)
                            {
                                blockCheck = blocks[k, i];
                                canMove = true;
                                sameNumber = true;
                                sameNumberCount++;
                            }
                            else if (blocks[k, i].number != blockOriginal.number)
                            {
                                break;
                            }
                        }

                        // �p�G �i�H���� �b���� ���ʰ϶�(��l�A�ˬd�A�O�_�ۦP�Ʀr)
                        if (canMove)
                        {
                            canMoveBlockAll = true;                                     // �����϶����i�H����
                            canMove = false;
                            MoveBlock(blockOriginal, blockCheck, sameNumber);
                            sameNumber = false;
                        }
                    }
                }

                break;

            case Direction.Down:

                for (int i = 0; i < blocks.GetLength(1); i++)
                {
                    sameNumberCount = 0;
                    for (int j = blocks.GetLength(0) - 2; j >= 0; j--)
                    {
                        blockOriginal = blocks[j, i];

                        // �p�G �Ӱ϶����Ʀr ���s �N �~�� (���L���j�����U�Ӱj��)
                        if (blockOriginal.number == 0) continue;

                        for (int k = j + 1; k <  blocks.GetLength(0) - sameNumberCount; k++)
                        {
                            print("�ˬd����:" + k);

                            if (blocks[k, i].number == 0)
                            {
                                blockCheck = blocks[k, i];
                                canMove = true;
                            }
                            else if (blocks[k, i].number == blockOriginal.number)
                            {
                                blockCheck = blocks[k, i];
                                canMove = true;
                                sameNumber = true;
                                sameNumberCount++;
                            }
                            else if (blocks[k, i].number != blockOriginal.number)
                            {
                                break;
                            }
                        }

                        // �p�G �i�H���� �b���� ���ʰ϶�(��l�A�ˬd�A�O�_�ۦP�Ʀr)
                        if (canMove)
                        {
                            canMoveBlockAll = true;                                     // �����϶����i�H����
                            canMove = false;
                            MoveBlock(blockOriginal, blockCheck, sameNumber);
                            sameNumber = false;
                        }
                    }
                }

                break;

        }

        if (canMoveBlockAll)
        {
            onEnemyTurn.Invoke();
            stateTurm = stateTurn.Enemy;
            CreateRandomNumberBlock();                          // ���ʫ� �ͦ��U�@���϶�
        }
        else 
        {
            print("���ಾ��");
        }
    }
    #endregion


    #region ��k�G���}

    public void ChangeToMyTurn()
    {
        stateTurm = stateTurn.My;
    }
    #endregion
    /// <summary>
    /// ���ʰ϶�
    /// </summary>
    /// <param name="blockOriginal"></param>
    /// <param name="blockCheck"></param>
    /// <param name="sameNumber"></param>
    private void MoveBlock(BlockData blockOriginal, BlockData blockCheck, bool sameNumber) 
    {
        #region
        // �N�쥻�����󲾰ʨ��ˬd�Ʀr���s���϶���m
        // �N�쥻�Ʀr�k�s�A�ˬd�Ʀr�ɤW
        // �N�쥻������M�šA�ˬd����ɤW
        blockOriginal.goBlock.transform.position = blockCheck.v2Position;

        if (sameNumber)
        {
            int number = blockCheck.number * 2;
            blockCheck.number = number;

            Destroy(blockOriginal.goBlock);
            blockCheck.goBlock.transform.Find("�Ʀr").GetComponent<Text>().text = number.ToString();

            // �ۦP�Ʀr�X�֨ƥ� Ĳ�o
            onSameNumberCombine.Invoke();
        }
        else
        {
            blockCheck.number = blockOriginal.number;
            blockCheck.goBlock = blockOriginal.goBlock;
        }

        blockOriginal.number = 0;
        blockOriginal.goBlock = null;
        #endregion

        PrintBlockData();
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
 public enum stateTurn
{
    My, Enemy
}