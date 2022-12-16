using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class sss : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera FirstCam;
    [SerializeField] CinemachineVirtualCamera SecondCam;
    //[SerializeField] CinemachineVirtualCamera ThirdCam;
    private bool camswitched = false;
    private void OnEnable()
    {
        CameraSwitcher.Register(FirstCam);
        CameraSwitcher.Register(SecondCam);
        //CameraSwitcher.Register(ThirdCam);
    }

    private void OnDisable()
    {
        CameraSwitcher.Unregister(FirstCam);
        CameraSwitcher.Unregister(SecondCam);
        //CameraSwitcher.Unregister(ThirdCam);
    }
    // Start is called before the first frame update
    void Start()
    {
        CameraSwitcher.SwitchCamera(FirstCam);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (!camswitched)
        {
            CameraSwitcher.SwitchCamera(SecondCam);
            camswitched = true;
        }
    }
}
