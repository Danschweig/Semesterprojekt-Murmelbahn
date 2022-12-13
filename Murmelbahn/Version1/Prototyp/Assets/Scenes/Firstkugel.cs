using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firstkugel : MonoBehaviour
{
    Vector3 Firstofblue()
    {
        float[] kugelpos = new float[4];
        kugelpos[0] = GameObject.FindGameObjectWithTag("blue1").transform.position.y;
        kugelpos[1] = GameObject.FindGameObjectWithTag("blue2").transform.position.y;
        kugelpos[2] = GameObject.FindGameObjectWithTag("blue3").transform.position.y;
        kugelpos[3] = GameObject.FindGameObjectWithTag("blue4").transform.position.y;

        if (kugelpos[0] < kugelpos[1] && kugelpos[0] < kugelpos[2] && kugelpos[0] < kugelpos[3])
        {
            return GameObject.FindGameObjectWithTag("blue1").transform.position;
        }
        else if (kugelpos[1] < kugelpos[2] && kugelpos[1] < kugelpos[3])
        {
            return GameObject.FindGameObjectWithTag("blue2").transform.position;
        }
        else if (kugelpos[2] < kugelpos[3])
        {
            return GameObject.FindGameObjectWithTag("blue3").transform.position;
        }
        else
        return GameObject.FindGameObjectWithTag("blue4").transform.position;
    }
    Vector3 Firstofred()
    {
        float[] kugelpos = new float[4];
        kugelpos[0] = GameObject.FindGameObjectWithTag("red1").transform.position.y;
        kugelpos[1] = GameObject.FindGameObjectWithTag("red2").transform.position.y;
        kugelpos[2] = GameObject.FindGameObjectWithTag("red3").transform.position.y;
        kugelpos[3] = GameObject.FindGameObjectWithTag("red4").transform.position.y;

        if (kugelpos[0] < kugelpos[1] && kugelpos[0] < kugelpos[2] && kugelpos[0] < kugelpos[3])
        {
            return GameObject.FindGameObjectWithTag("red1").transform.position;
        }
        else if (kugelpos[1] < kugelpos[2] && kugelpos[1] < kugelpos[3])
        {
            return GameObject.FindGameObjectWithTag("red2").transform.position;
        }
        else if (kugelpos[2] < kugelpos[3])
        {
            return GameObject.FindGameObjectWithTag("red3").transform.position;
        }
        else
            return GameObject.FindGameObjectWithTag("red4").transform.position;
    }
    Vector3 Firstofgreen()
    {
        float[] kugelpos = new float[4];
        kugelpos[0] = GameObject.FindGameObjectWithTag("green1").transform.position.y;
        kugelpos[1] = GameObject.FindGameObjectWithTag("green2").transform.position.y;
        kugelpos[2] = GameObject.FindGameObjectWithTag("green3").transform.position.y;
        kugelpos[3] = GameObject.FindGameObjectWithTag("green4").transform.position.y;

        if (kugelpos[0] < kugelpos[1] && kugelpos[0] < kugelpos[2] && kugelpos[0] < kugelpos[3])    //kugelpos1 wird verglichen und wenn sie erste ist returned
        {
            return GameObject.FindGameObjectWithTag("green1").transform.position;
        }
        else if (kugelpos[1] < kugelpos[2] && kugelpos[1] < kugelpos[3])
        {
            return GameObject.FindGameObjectWithTag("green2").transform.position;
        }
        else if (kugelpos[2] < kugelpos[3])
        {
            return GameObject.FindGameObjectWithTag("green3").transform.position;
        }
        else
            return GameObject.FindGameObjectWithTag("green4").transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3[] kugelpos = new Vector3[3];
        kugelpos[0] = Firstofblue();
        kugelpos[1] = Firstofred();
        kugelpos[2] = Firstofgreen();

        if (kugelpos[0].y < kugelpos[1].y && kugelpos[0].y < kugelpos[2].y)
            transform.position = kugelpos[0];
        else if (kugelpos[1].y < kugelpos[2].y)
            transform.position = kugelpos[1];
        else
            transform.position = kugelpos[2];



        /*
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
    */
    }
}
