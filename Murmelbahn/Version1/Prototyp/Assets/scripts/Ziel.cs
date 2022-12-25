using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ziel : MonoBehaviour
{

    private AudioSource finishSound;
    //public Levelbutton weiterbutton;
    private bool levelCompleted = false;
    private CoinManager m;

    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
        CoinManager coinManager = GameObject.FindGameObjectWithTag("CoinCounter").GetComponent<CoinManager>();
        m = coinManager;
      //  weiterbutton = GetComponent<Levelbutton>();
      //  weiterbutton.DisableButton();
    }


    private void OnTriggerEnter(Collider collision)
    {
        if(!levelCompleted)
        {
            levelCompleted = true;
            finishSound.Play();
            m.Addmoney();
         //   weiterbutton.EnableButton();
        }
    }

}
