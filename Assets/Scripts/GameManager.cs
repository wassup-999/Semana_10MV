using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("References")]
    public static GameManager Instance; 
    public UIManager uiManager;
    public TestMRU mru;
    public TestMRUV mruv;   
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    
}
