using UnityEngine;

/// <summary>
/// �P�_�� switch
/// </summary>
public class LearnSwitch : MonoBehaviour
{
    public string equipment;

    private void Start()
    {
        // Switch �y�k:
        // switch (�n�P�_�����)
        // {
        //      case �� 1:
        //          �{�����e;
        //          break;
        //      case �� 2:
        //          �{�����e;
        //          break;
        //      default:            // ���Ƥ��ŦX�W����case "�i�ٲ�"
        //          �{�����e;
        //          break;
        // }

        switch (equipment)
        {
            case "�M�l":
                print("�˳ƤM�l");
                break;
            case "����":
                print("�˳ƴ���");
                break;
            default:
                print("���ڥh���Z��");
                break;
        }
    }
}
