using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kugeln : MonoBehaviour
{
   
    
    // Start is called before the first frame update
    void Start()
    {
        KinematicTrue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
            KinematicFalse();
    }

    public void KinematicTrue()
    {
        GameObject.FindGameObjectWithTag("blue1").GetComponent<Rigidbody>().isKinematic = true;
        GameObject.FindGameObjectWithTag("blue2").GetComponent<Rigidbody>().isKinematic = true;
        GameObject.FindGameObjectWithTag("blue3").GetComponent<Rigidbody>().isKinematic = true;
        GameObject.FindGameObjectWithTag("blue4").GetComponent<Rigidbody>().isKinematic = true;
        GameObject.FindGameObjectWithTag("red1").GetComponent<Rigidbody>().isKinematic = true;
        GameObject.FindGameObjectWithTag("red2").GetComponent<Rigidbody>().isKinematic = true;
        GameObject.FindGameObjectWithTag("red3").GetComponent<Rigidbody>().isKinematic = true;
        GameObject.FindGameObjectWithTag("red4").GetComponent<Rigidbody>().isKinematic = true;
        GameObject.FindGameObjectWithTag("green1").GetComponent<Rigidbody>().isKinematic = true;
        GameObject.FindGameObjectWithTag("green2").GetComponent<Rigidbody>().isKinematic = true;
        GameObject.FindGameObjectWithTag("green3").GetComponent<Rigidbody>().isKinematic = true;
        GameObject.FindGameObjectWithTag("green4").GetComponent<Rigidbody>().isKinematic = true;
    }
    public void KinematicFalse()
    {
        GameObject.FindGameObjectWithTag("blue1").GetComponent<Rigidbody>().isKinematic = false;
        GameObject.FindGameObjectWithTag("blue2").GetComponent<Rigidbody>().isKinematic = false;
        GameObject.FindGameObjectWithTag("blue3").GetComponent<Rigidbody>().isKinematic = false;
        GameObject.FindGameObjectWithTag("blue4").GetComponent<Rigidbody>().isKinematic = false;
        GameObject.FindGameObjectWithTag("red1").GetComponent<Rigidbody>().isKinematic = false;
        GameObject.FindGameObjectWithTag("red2").GetComponent<Rigidbody>().isKinematic = false;
        GameObject.FindGameObjectWithTag("red3").GetComponent<Rigidbody>().isKinematic = false;
        GameObject.FindGameObjectWithTag("red4").GetComponent<Rigidbody>().isKinematic = false;
        GameObject.FindGameObjectWithTag("green1").GetComponent<Rigidbody>().isKinematic = false;
        GameObject.FindGameObjectWithTag("green2").GetComponent<Rigidbody>().isKinematic = false;
        GameObject.FindGameObjectWithTag("green3").GetComponent<Rigidbody>().isKinematic = false;
        GameObject.FindGameObjectWithTag("green4").GetComponent<Rigidbody>().isKinematic = false;
    }
}
