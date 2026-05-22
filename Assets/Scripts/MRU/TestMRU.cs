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
    }
    public void Test()
    {
        Vector3 dir = Vector3.right;
        transform.Translate(dir * speed * Time.deltaTime);
        if (speed <= 0)
        {
            Debug.Log("The object has stopped moving : " + gameObject.transform.position);
        }
    }
}
