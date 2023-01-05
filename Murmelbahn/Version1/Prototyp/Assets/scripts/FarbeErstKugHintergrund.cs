using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FarbeErstKugHintergrund : MonoBehaviour
{
    Color32 farbeRot;
    Color32 farbeGruen;
    Color farbeBlau;
    // Start is called before the first frame update
    void Start()
    {
        farbeRot = new Color32(255,0,0,255);
        farbeGruen = new Color(0.1607843f, 0.5843138f, 0.2f,255);
        farbeBlau = new Color(0,0,1,255);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<RawImage>().color = farbeGruen;
    }
    public void ChangeToRed()
    {
        gameObject.GetComponent<RawImage>().color = farbeRot;
    }
    public void ChangeToGreen()
    {
        gameObject.GetComponent<RawImage>().color = farbeGruen;
    }
    public void ChangeToBlau()
    {
        gameObject.GetComponent<RawImage>().color = farbeBlau;
    }


}
