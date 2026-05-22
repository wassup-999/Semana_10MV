using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("References")]
    public TextMeshProUGUI timer;
    [Header("Variables")]
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
        if (Seconds < 9.9f && Minutes < 1)
        {       
            timer.text = "Current time : " + Minutes.ToString() + ": 0" + Seconds.ToString("f0");          
        }
        else
        {           
             timer.text = "Current time : " + Minutes.ToString() + ":" + Seconds.ToString("f0");
        }
        if(Seconds >= 5)
        {
            GameManager.Instance.mru.speed = 0;
            Debug.Log("The object has stopped at : " + 5 + " seconds");
        }

        if (Seconds >=2)
        {
            GameManager.Instance.mruv.speed += GameManager.Instance.mruv.desacceleration;
        }

        if(GameManager.Instance.mruv.speed <= 0)
        {
            GameManager.Instance.mruv.speed = 0;
        }
    }
}
