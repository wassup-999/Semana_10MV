using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("References")]
    public TextMeshProUGUI timer;
    [Header("Variables")]
    
    public float Seconds;
    void Start()
    {
        
    }

    
    void Update()
    {
        TimeOnScreen();
    }

    public void TimeOnScreen()
    {
        Seconds += Time.deltaTime;
        if (Seconds < 9.9f)
        {       
            timer.text = "Current time : " + "0" + Seconds.ToString("f0");          
        }
        else
        {           
             timer.text = "Current time : " + Seconds.ToString("f0");
        }     
    }
}
