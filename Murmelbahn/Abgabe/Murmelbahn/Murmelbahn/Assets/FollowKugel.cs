using UnityEngine;

public class FollowKugel : MonoBehaviour
{
     //public Transform player;
    public Vector3 offset;
    void FollowFirst()
    {
        if (GameObject.FindGameObjectWithTag("red").transform.position.y < GameObject.FindGameObjectWithTag("blue").transform.position.y
                && GameObject.FindGameObjectWithTag("red").transform.position.y < GameObject.FindGameObjectWithTag("green").transform.position.y)
        {
            transform.position = GameObject.FindGameObjectWithTag("red").transform.position + offset;
        }
        else if (GameObject.FindGameObjectWithTag("green").transform.position.y < GameObject.FindGameObjectWithTag("blue").transform.position.y
                && GameObject.FindGameObjectWithTag("green").transform.position.y < GameObject.FindGameObjectWithTag("red").transform.position.y)
        {
            transform.position = GameObject.FindGameObjectWithTag("green").transform.position + offset;
        }
        else
            transform.position = GameObject.FindGameObjectWithTag("blue").transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        FollowFirst();
        //player = getfirstplayer();

        //transform.position = player.position + offset; //Kugel mit niedrigstem X ist vorderste
    }
}
