using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ziel : MonoBehaviour
{

    private AudioSource finishSound;
    private bool levelCompleted = false;
    private CoinManager cm;
    public GameObject Firstkugelscript;
    public Text Winnertext;
    public Levelbutton weiterbutton;
    public GameObject GewetteteFarbeScript;

    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
        CoinManager coinManager = GameObject.FindGameObjectWithTag("CoinCounter").GetComponent<CoinManager>();
        cm = coinManager;
        Winnertext.enabled = false;
        weiterbutton.DisableButton();
    }


    private void OnTriggerEnter(Collider collision)
    {
       //farbe = Firstkugelscript.GetComponent<Firstkugel>().getfirstFarbe();


        if (!levelCompleted)
        {
            levelCompleted = true;
            Winnertext.text = "Winner is: " + Firstkugelscript.GetComponent<Firstkugel>().getfirstFarbe();
            Winnertext.enabled = true;
            weiterbutton.EnableButton();

            if(GewetteteFarbeScript.GetComponent<KugelWetteUI>().GewetteteFarbe() == Firstkugelscript.GetComponent<Firstkugel>().getfirstFarbe())
            {
                finishSound.Play();
                cm.Addmoney();
            }
         //   weiterbutton.EnableButton();
        }
    }

}
