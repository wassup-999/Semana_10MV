using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI timer;
    public float Minutes;
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
        timer.text = "Current time : " + Minutes.ToString() + ":" + Seconds.ToString("f0");
    }
}
