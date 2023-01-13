using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ziel : MonoBehaviour
{

    public AudioSource Winner;
    public AudioSource Loosing;

    private bool levelCompleted = false;
    private CoinManager cm;
    public GameObject Firstkugelscript;
    public Text Winnertext;
    public Levelbutton weiterbutton;
    public GameObject GewetteteFarbeScript;

    private void Start()
    {
       // Winner = GetComponent<AudioSource>();

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
           // Winnertext.text = "Winner is: " + GameObject.FindGameObjectWithTag("firstkugel").GetComponent<Firstkugel>().GetComponent<Firstkugel>().getfirstFarbe();
            Winnertext.enabled = true;
            weiterbutton.EnableButton();
            GameObject.FindGameObjectWithTag("murmeln").GetComponent<AudioSource>().Stop();

            if (GewetteteFarbeScript.GetComponent<KugelWetteUI>().GewetteteFarbe() == Firstkugelscript.GetComponent<Firstkugel>().getfirstFarbe())
            {
                Winner.Play();
                cm.Addmoney();
            }
            else
                Loosing.Play();
         //   weiterbutton.EnableButton();
        }
    }

}
