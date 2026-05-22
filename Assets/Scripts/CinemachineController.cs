using NUnit.Framework.Internal;
using Unity.Cinemachine;
using UnityEngine;

public class CinemachineController : MonoBehaviour
{
    [Header("References")]
    public CinemachineCamera CameraTest1;
    public CinemachineCamera CameraTest2;
    public Test CamerasTest;
    void Start()
    {
        
    }

   
    void Update()
    {
        ChangePriority();
    }
    public void ChangePriority()
    {
        switch (CamerasTest)
        {
            case Test.MRU:
            {
                CameraTest1.Priority = 1;
                CameraTest2.Priority = 0;
                    //CamerasTest = Test.MRUV;
                }
            break;

            case Test.MRUV:
            {
                CameraTest2.Priority = 1;
                CameraTest1.Priority = 0;
            }
            break;
        }
    }
}
