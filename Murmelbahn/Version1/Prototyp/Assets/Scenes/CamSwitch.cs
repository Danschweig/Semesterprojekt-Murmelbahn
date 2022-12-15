using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamSwitch : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera firstCam;
    [SerializeField] CinemachineVirtualCamera SecondCam;


    private void OnEnable() 
    {
        CameraSwitcher.Register(firstCam);
        CameraSwitcher.Register(SecondCam);
    }

    private void OnDisable()
    {
        CameraSwitcher.Unregister(firstCam);
        CameraSwitcher.Unregister(SecondCam);
    }




    // Start is called before the first frame update
    void Start()
    {
        CameraSwitcher.SwitchCamera(firstCam);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y<=-3)
        {
            CameraSwitcher.SwitchCamera(SecondCam);
        }
        
    }
}
