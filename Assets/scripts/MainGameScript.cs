using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameScript : MonoBehaviour
{
    public static bool HasActiveMissile;
    public static GameObject ActiveMissile;
    public GameObject MissilesCounter;
    void Start()
    {
        HasActiveMissile = false;
        MissilesCounter = GameObject.Find("ActiveTargetsCounter");
        Timer timer = GameObject.Find("Main Camera").GetComponent<Timer>();
        StartCoroutine(timer.Countdown(10, 1));
    }
    
    void Update()
    {
        MissilesCounter.GetComponent<TextMesh>().text = GameObject.FindGameObjectsWithTag("Missile").Length.ToString();
    }
}
