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
        Vector3 dir = Vector3.down;

        transform.Translate(dir * speed * Time.deltaTime);

    }
}
