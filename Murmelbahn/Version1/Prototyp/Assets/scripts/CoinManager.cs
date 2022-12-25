using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        money.text = PlayerPrefs.GetInt("Money", 0).ToString(); 
    }

    public void Addmoney()
    {
        geld++;
        PlayerPrefs.SetInt("Money", geld);
    }
}
