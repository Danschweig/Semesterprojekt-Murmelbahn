using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ziel : MonoBehaviour
{

    private AudioSource finishSound;
    private bool levelCompleted = false;

    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter(Collider collision)
    {
        if(!levelCompleted)
        {
            levelCompleted = true;
            finishSound.Play();
        }
    }

}
