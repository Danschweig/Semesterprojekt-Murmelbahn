using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamSwitch : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera FirstCam;
    [SerializeField] CinemachineVirtualCamera SecondCam;
    [SerializeField] CinemachineVirtualCamera ThirdCam;
    public float FirstChange;
    public float SecondChange;
   

    /*
    private void OnEnable() 
    {
        CameraSwitcher.Register(FirstCam);
        CameraSwitcher.Register(SecondCam);
        CameraSwitcher.Register(ThirdCam);
    }

    private void OnDisable()
    {
        CameraSwitcher.Unregister(FirstCam);
        CameraSwitcher.Unregister(SecondCam);
        CameraSwitcher.Unregister(ThirdCam);
    }
    */
   



    // Start is called before the first frame update
    void Start()
    {
        CameraSwitcher.SwitchCamera(FirstCam);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y<=FirstChange && gameObject.transform.position.y >SecondChange)
        {
            CameraSwitcher.SwitchCamera(SecondCam);
        }
        else if(gameObject.transform.position.y <= SecondChange)
        {
            CameraSwitcher.SwitchCamera(ThirdCam);
        }
        
    }
   
}
