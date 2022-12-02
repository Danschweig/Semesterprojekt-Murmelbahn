using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliding : MonoBehaviour
{
    public float boostSpeed;
    private Vector3 velo ;
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
       // collision.rigidbody.velocity = collision.rigidbody.velocity * boostSpeed;
        GameObject kugel = collision.collider.gameObject;

        Rigidbody rig = kugel.GetComponent<Rigidbody>();

        velo = rig.velocity;
       // velo.y = 0;

        rig.AddForce(velo * boostSpeed , ForceMode.VelocityChange);

        //GameObject rig = kugel.GetComponent<Rigidbody>();

        //mat.bounceCombine = PhysicMaterialCombine.Maximum;
            //rig.AddForce(1000,0,0);
    }
}
