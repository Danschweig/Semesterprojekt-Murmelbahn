using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackAForward : MonoBehaviour
{
    public Vector3 speed;
    private Vector3 startPos;
    private Vector3 endPos;

    public float strecke;
    // Start is called before the first frame update
    void Start()
    {
        startPos = gameObject.transform.position;
        endPos = startPos;
        endPos.z += strecke;
        gameObject.GetComponent<Rigidbody>().AddForce(speed, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.z <= startPos.z)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(speed*Time.deltaTime, ForceMode.VelocityChange);
        }
        else if (gameObject.transform.position.z >= endPos.z)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(-speed*Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}
