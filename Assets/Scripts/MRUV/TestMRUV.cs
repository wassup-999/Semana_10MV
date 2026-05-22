using UnityEngine;

public class TestMRUV : MonoBehaviour
{
    [Header("Parameters")]
    public float speed;
    public float desacceleration;
    void Start()
    {
        
    }

    
    void Update()
    {
        Test();
        TestSpeed();
    }
    public void Test()
    {
        Vector3 dir = Vector3.forward;
        transform.Translate(dir * speed * Time.deltaTime);
            
    }
    public void TestSpeed()
    {
        if (GameManager.Instance.uiManager.Seconds >= 2)
        {
            speed += desacceleration;          
            Debug.Log("");
        }
        if(speed <= 0)
        {
            speed = 0;
            //Debug.Log("The object has stopped moving at : " + GameManager.Instance.uiManager.Seconds + " seconds and onto position : " + gameObject.transform.position);
        }
    }
}
