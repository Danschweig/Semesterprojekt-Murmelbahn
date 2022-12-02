using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtFirstKugel : MonoBehaviour
{
    void LookAtFirst()
    {
        if (GameObject.FindGameObjectWithTag("red").transform.position.y < GameObject.FindGameObjectWithTag("blue").transform.position.y
                && GameObject.FindGameObjectWithTag("red").transform.position.y < GameObject.FindGameObjectWithTag("green").transform.position.y)
        {
            transform.LookAt(GameObject.FindGameObjectWithTag("red").transform.position);   // = GameObject.FindGameObjectWithTag("red");
        }
        else if (GameObject.FindGameObjectWithTag("green").transform.position.y < GameObject.FindGameObjectWithTag("blue").transform.position.y
                && GameObject.FindGameObjectWithTag("green").transform.position.y < GameObject.FindGameObjectWithTag("red").transform.position.y)
        {
            transform.LookAt(GameObject.FindGameObjectWithTag("green").transform.position); //= GameObject.FindGameObjectWithTag("green").transform.position + offset;
        }
        else
            transform.LookAt(GameObject.FindGameObjectWithTag("blue").transform.position);// transform.position = GameObject.FindGameObjectWithTag("blue").transform.position + offset;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookAtFirst();
    }
}
