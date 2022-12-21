using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeListener : MonoBehaviour
{
    static GameObject LampGreen;
    static GameObject LampRed;
    [SerializeField]
    private static Sprite LampG1;
    [SerializeField]
    private static Sprite LampR1;
    [SerializeField]
    private static Sprite LampG2;
    [SerializeField]
    private static Sprite LampR2;
    public static bool CodeReading;
	public static bool correctCode = false;
    public static string CurrentCodeInput = "";

    void Start()
    {
        LampGreen = GameObject.Find("Lamp_green");
        LampRed = GameObject.Find("Lamp_red");
    }
    public static IEnumerator readCode(string code)
    {
        CodeReading = true; 
		while(CodeReading)
		{
			if(CurrentCodeInput.Length == code.Length)
			{
				CodeReading = false;
			}
			else
			{
				yield return new WaitForSeconds(0.01f); // Небольшая пауза между итерациями, чтобы сильно не нагружать процессор
			}
		}
		if(CurrentCodeInput == code)
		{
			correctCode = true;
		}
        CurrentCodeInput = "";
		yield return null;
    }

    void Update()
    {
        
    }
}
