using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firstkugel : MonoBehaviour
{
    public string erstekugelfarbe;
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
 

    // Update is called once per frame
    void Update()
    {
        Vector3[] kugelpos = new Vector3[3];
        kugelpos[0] = Firstofblue();
        kugelpos[1] = Firstofred();
        kugelpos[2] = Firstofgreen();

        if (kugelpos[0].y < kugelpos[1].y && kugelpos[0].y < kugelpos[2].y)
        {
            transform.position = kugelpos[0];
            erstekugelfarbe = "blau";
        }
        else if (kugelpos[1].y < kugelpos[2].y)
        {
            transform.position = kugelpos[1];
            erstekugelfarbe = " rot";
        }
        else
        {
            transform.position = kugelpos[2];
            erstekugelfarbe = "grün";
        }
    }

    public string getfirstFarbe()//string farbe)
    {
        // farbe = erstekugelfarbe;
        return erstekugelfarbe;
    }
}