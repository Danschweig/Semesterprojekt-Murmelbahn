using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zielerkennung : MonoBehaviour
{

    private AudioSource finishSound;
    // Start is called before the first frame update
    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "firstkugel")
        {
            finishSound.Play();
        }
    }

}
