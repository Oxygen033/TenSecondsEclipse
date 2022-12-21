using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    [SerializeField] private float StartTime;
    private bool IsActive = true;
    static GameObject TimerText;
    static GameObject NoSScreen;
    public GameObject Missile;
    static TextMesh tm;
    static int mc = 1;
    void Start()
    {
        NoSScreen = GameObject.Find("NoSignalScreen");
    }

    public IEnumerator Countdown(int time, int missileCount)
    {
        GameObject TimerText = GameObject.Find("TimerTextBlock");
        tm = TimerText.GetComponent<TextMesh>();
        for (int i = 0; i < missileCount; i++)
        {
            Instantiate(Missile, new Vector3(Random.Range(-2.92f, 9.21f), Random.Range(3.99f, 1.85f), -5.5f), new Quaternion(0, 0, 0, 0));
        }
        while (time > 0)
        {
            if (time == 10)
            {
                 tm.text = "00:" + time;
            }
            else
            {
                 tm.text = "00:0" + time;
            }
            Debug.Log(time--);
            yield return new WaitForSeconds(1);
        }
        if(GameObject.FindGameObjectsWithTag("Missile").Length == 0)
        {
            StartCoroutine(Countdown(10, mc++));
        }
        else
        {
            Color color = NoSScreen.GetComponent<SpriteRenderer>().color;
            color.a = 1.0f;
            NoSScreen.GetComponent<SpriteRenderer>().color = color;
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(2);

        }
        yield return null;
    }
}
