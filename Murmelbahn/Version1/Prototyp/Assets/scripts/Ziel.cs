using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ziel : MonoBehaviour
{

    private AudioSource finishSound;
    //public Levelbutton weiterbutton;
    private bool levelCompleted = false;

    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
      //  weiterbutton = GetComponent<Levelbutton>();
      //  weiterbutton.DisableButton();
    }


    private void OnTriggerEnter(Collider collision)
    {
        if(!levelCompleted)
        {
            levelCompleted = true;
            finishSound.Play();
         //   weiterbutton.EnableButton();
        }
    }

}
