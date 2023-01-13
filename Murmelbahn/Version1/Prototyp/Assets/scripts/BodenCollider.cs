using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodenCollider : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GameObject kugel = collision.collider.gameObject;
        if(kugel != GameObject.FindGameObjectWithTag("firstkugel"))
        {
           // kugel.transform.position.Set() = 10;
            kugel.transform.position = new Vector3(0, 150000, 0);
           
           // kugel.SetActive(false);
            //kugel.GetComponent<Rigidbody>().isKinematic = true;
        }

    }

}
