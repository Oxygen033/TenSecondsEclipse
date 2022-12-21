using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsInput : MonoBehaviour
{
    [SerializeField]
    private int ButtonNumber;
    void Start()
    {
        
    }
    private void OnMouseDown()
    {
        if (CodeListener.CodeReading)
        {
            switch (ButtonNumber)
            {
                case 1:
                    CodeListener.CurrentCodeInput += "1";
                    break;
                case 2:
                    CodeListener.CurrentCodeInput += "2";
                    break;
                case 3:
                    CodeListener.CurrentCodeInput += "3";
                    break;
                case 4:
                    CodeListener.CurrentCodeInput += "4";
                    break;
            }
        }
    }
}
