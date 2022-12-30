using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class KlappeOeffnen : MonoBehaviour
{
    private FixedJoint fixedJ;
    // Start is called before the first frame update
    void Start()
    {
        fixedJ = gameObject.GetComponent<FixedJoint>();

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
    }
}
