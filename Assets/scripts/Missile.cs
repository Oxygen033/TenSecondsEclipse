using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour
{
    private string DefuseCode;
    public GameObject CodeTextBlock;
    void Start()
    {
        for (int i = 0; i < Random.Range(1, 3); i++)
        {
            DefuseCode += Random.Range(1, 4).ToString();
        }
        DefuseCode.Replace("0", "1");
        CodeTextBlock = GameObject.Find("CodeTextBlock");
    }

    private void OnMouseDown()
    {
        if (!MainGameScript.HasActiveMissile) //���� ��� ������ ���������� ��������
        {
            MainGameScript.ActiveMissile = gameObject;
            StartCoroutine(check());
        }
    }
	
	private IEnumerator check()
	{
		MainGameScript.HasActiveMissile = true; //���������� ��� ���� ���������� ������
        CodeTextBlock.GetComponent<TextMesh>().text = DefuseCode; // �������� ��� � ��������� ������
        yield return StartCoroutine(CodeListener.readCode(DefuseCode)); // ����� readcode � ��������������� ����� � �������� ���������
        if (CodeListener.correctCode)
        {
            ExecuteButtonScript.IsActive = true;
            MainGameScript.HasActiveMissile = false;
			CodeListener.correctCode = false;
        }
        else
        {
            MainGameScript.HasActiveMissile = false;
            MainGameScript.ActiveMissile = null;
        }
		yield return null;
	}
}
