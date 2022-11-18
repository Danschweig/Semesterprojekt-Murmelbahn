using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstkugel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("red").transform.position.y < GameObject.FindGameObjectWithTag("blue").transform.position.y
                && GameObject.FindGameObjectWithTag("red").transform.position.y < GameObject.FindGameObjectWithTag("green").transform.position.y)
        {
                transform.position = GameObject.FindGameObjectWithTag("red").transform.position;
        }
        else if (GameObject.FindGameObjectWithTag("green").transform.position.y < GameObject.FindGameObjectWithTag("blue").transform.position.y
                && GameObject.FindGameObjectWithTag("green").transform.position.y < GameObject.FindGameObjectWithTag("red").transform.position.y)
        {
            transform.position = GameObject.FindGameObjectWithTag("green").transform.position;
        }
        else
            transform.position = GameObject.FindGameObjectWithTag("blue").transform.position;
    }
}
