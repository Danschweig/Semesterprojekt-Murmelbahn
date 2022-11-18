using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliding : MonoBehaviour
{
    public float boostSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.rigidbody.velocity = collision.rigidbody.velocity * boostSpeed;
        //GameObject kugel = collision.collider.gameObject;

        //Rigidbody rig = kugel.GetComponent<Rigidbody>();
        
        //rig.AddForce(1000,0,0);
    }
}
