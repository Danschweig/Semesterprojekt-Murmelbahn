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
        //geld = 0;
        //PlayerPrefs.SetInt("Money", geld);
    }

    // Update is called once per frame
    void Update()
    {
        money.text = "coins: " + PlayerPrefs.GetInt("Money", 0).ToString(); 
    }

    public void Addmoney()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2)
            geld += 5;
        else if (SceneManager.GetActiveScene().buildIndex == 3)
            geld += 10;
        PlayerPrefs.SetInt("Money", geld);
    }
}
