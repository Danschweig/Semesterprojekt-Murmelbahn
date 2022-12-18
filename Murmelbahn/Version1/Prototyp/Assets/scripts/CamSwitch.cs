using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Camswitch : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera FirstCam;
    [SerializeField] CinemachineVirtualCamera SecondCam;
    [SerializeField] CinemachineVirtualCamera StartCam;
    private bool camswitched = false;
    private void OnEnable()
    {
        CameraSwitcher.Register(FirstCam);
        CameraSwitcher.Register(SecondCam);
        CameraSwitcher.Register(StartCam);
    }

    private void OnDisable()
    {
        CameraSwitcher.Unregister(FirstCam);
        CameraSwitcher.Unregister(SecondCam);
        CameraSwitcher.Unregister(StartCam);
    }
    // Start is called before the first frame update
    void Start()
    {
        CameraSwitcher.SwitchCamera(StartCam);
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
