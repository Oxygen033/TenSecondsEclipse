using Unity.VisualScripting;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    private float StartTime = 10;
    private bool Active1 = true;
    void Start()
    {
        
    }
    
    void Update()
    {
        if (Active1)
        {
            if (StartTime > 0)
            {
                StartTime -= Time.deltaTime;
            }
            else
            {

                Active1 = false;
            }
        }
    }
}
