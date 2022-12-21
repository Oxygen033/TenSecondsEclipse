using UnityEngine;

public class ExecuteButtonScript : MonoBehaviour
{
    public static bool IsActive = false;
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        if(IsActive)
        {
            Destroy(MainGameScript.ActiveMissile);
            IsActive = false;
            MainGameScript.ActiveMissile = null;
        }
    }
}
