using UnityEngine;

public class TestMRU : MonoBehaviour
{
    [Header("Settings")]
    public float speed;
    void Start()
    {
        
    }

    
    void Update()
    {
        Test();
        SpeedTest();
    }
    public void Test()
    {
        Vector3 dir = Vector3.right;
        transform.Translate(dir * speed * Time.deltaTime);
        
    }
    public void SpeedTest()
    {
        if (GameManager.Instance.uiManager.Seconds >= 5)
        {
            speed *= 0;
            Debug.Log("The object has stopped moving at : " + 5 + " second and onto position : " + gameObject.transform.position);         
        }       
    }
}
