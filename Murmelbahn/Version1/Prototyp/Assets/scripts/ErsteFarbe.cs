using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ErsteFarbe : MonoBehaviour
{
    public Text ersteKugelFarbe;
    private Firstkugel farbe;
    // Start is called before the first frame update
    void Start()
    {
        farbe = GameObject.FindGameObjectWithTag("firstkugel").GetComponent<Firstkugel>();
    }

    // Update is called once per frame
    void Update()
    {
        ersteKugelFarbe.text = farbe.GetComponent<Firstkugel>().getfirstFarbe();
    }
}