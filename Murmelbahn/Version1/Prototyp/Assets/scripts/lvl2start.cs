using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl2start : MonoBehaviour
{
    public int geld;
    private void Start()
    {
        geld = PlayerPrefs.GetInt("Money", 0);
    }
    public void StartLevel2()
    {
        if (geld >= 20)
        {
            geld -= 20;
            PlayerPrefs.SetInt("Money", geld);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
}
