using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinManager : MonoBehaviour
{
    public int geld;
    public Text money;
    // Start is called before the first frame update
    void Start()
    {
        geld = PlayerPrefs.GetInt("Money", 0);
    }

    // Update is called once per frame
    void Update()
    {
        money.text = "coins: " + PlayerPrefs.GetInt("Money", 0).ToString(); 
    }

    public void Addmoney()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            // geld += 5;
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money", 0) + 5);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money", 0) + 10);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money", 0) + 20);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money", 0) + 30);
        }
        //geld += 10;
        //PlayerPrefs.SetInt("Money", geld);
    }
}
