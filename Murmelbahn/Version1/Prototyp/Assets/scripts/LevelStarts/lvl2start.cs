using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class lvl2start : MonoBehaviour
{
    public int geld;
    public Text zuTeuer;
    private void Start()
    {
        geld = PlayerPrefs.GetInt("Money", 0);
        zuTeuer.enabled = false;
    }
    public void StartLevel2()
    {
        if (geld >= 10)
        {
            geld -= 10;
            PlayerPrefs.SetInt("Money", geld);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
        else
        {
            //zu teuer
            zuTeuer.enabled = true;
            Invoke("ZuTeuerdisable", 1.5f);
        }
    }
    private void ZuTeuerdisable()
    {
        zuTeuer.enabled = false;
    }
}
