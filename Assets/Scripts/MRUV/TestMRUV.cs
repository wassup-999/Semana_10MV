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
    }
    public void Test()
    {
        Vector3 dir = Vector3.forward;
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
