using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ErsteFarbe : MonoBehaviour
{
    public Text ersteKugelFarbe;
    public GameObject background;
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
        if (ersteKugelFarbe.text == " rot")
            background.GetComponent<FarbeErstKugHintergrund>().ChangeToRed();
        else if (ersteKugelFarbe.text == "blau")
            background.GetComponent<FarbeErstKugHintergrund>().ChangeToBlau();
        else if (ersteKugelFarbe.text == "gr�n")
            background.GetComponent<FarbeErstKugHintergrund>().ChangeToGreen();
    }
}