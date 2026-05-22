using UnityEngine;

public class TestMRUV : MonoBehaviour
{
   
    [Header("Parameters")]
    public float speed;
    public float aceleracion;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    /*
    public void Test()
    {
        if (speed > 0)
        {
            speed += acceleracion * Time.deltaTime;            
            if (speed < 0) speed = 0;
            transform.Translate(transform.forward * speed * Time.deltaTime);
        }
    }
    */
    public void Test()
    {
        if(speed > 0)
        {
            Debug.Log("The object is desacelerating");
            speed += aceleracion * Time.deltaTime;           
            if (speed <= 0)
            {
                speed = 0;
            }
            transform.Translate(transform.forward * speed * Time.deltaTime);
        }
    }   
}
