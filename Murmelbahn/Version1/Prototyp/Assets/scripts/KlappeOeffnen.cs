using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class KlappeOeffnen : MonoBehaviour
{
    private FixedJoint fixedJ;
    private Text starttext;
    public GameObject kugelBoxA;
    public GameObject kugelBoxB;
    public GameObject kugelBoxC;
    
   
    // Start is called before the first frame update
    void Start()
    {
        fixedJ = gameObject.GetComponent<FixedJoint>();
        starttext = GameObject.FindGameObjectWithTag("starttext").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Open();
    }

    void Open()
    {
        fixedJ.breakForce = 0;
        kugelBoxA.GetComponent<BoxCollider>().enabled = false;
        kugelBoxB.GetComponent<BoxCollider>().enabled = false;
        kugelBoxC.GetComponent<BoxCollider>().enabled = false;
        starttext.enabled = false;


    }
}
