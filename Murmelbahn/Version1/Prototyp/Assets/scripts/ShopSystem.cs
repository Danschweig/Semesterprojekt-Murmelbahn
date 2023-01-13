using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShopSystem : MonoBehaviour
{
    public int money;

    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;

    public int geld;
    public Text zuTeuer;

    // Start is called before the first frame update
    void Start()
    {
        geld = PlayerPrefs.GetInt("Money", 0);
        zuTeuer.enabled = false;
        //PlayerPrefs.SetInt("Level2", 0);
        //PlayerPrefs.SetInt("Level3", 0);
        //PlayerPrefs.SetInt("Level4", 0);

        //PlayerPrefs.SetInt("Money", 80);

        if (PlayerPrefs.GetInt("Level2", 0) == 1)
        {
            Text2.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Level3", 0) == 1)
        {
            Text3.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Level4", 0) == 1)
        {
            Text4.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void ZuTeuerdisable()
    {
        zuTeuer.enabled = false;
    }
    public void StartLevel1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void StartLevel2()
    {
        if (PlayerPrefs.GetInt("Level2", 0) == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
         else if (geld >= 10)
        {
            Text2.SetActive(false);
            geld -= 10;
            PlayerPrefs.SetInt("Money", geld);
            PlayerPrefs.SetInt("Level2", 1);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
        else
        {
            //zu teuer
            zuTeuer.enabled = true;
            Invoke("ZuTeuerdisable", 1.5f);
        }
    }

    public void StartLevel3()
    {
        if (PlayerPrefs.GetInt("Level3", 0) == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
        else if (geld >= 20)
        {
            Text3.SetActive(false);
            geld -= 20;
            PlayerPrefs.SetInt("Money", geld);
            PlayerPrefs.SetInt("Level3", 1);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
        else
        {
            //zu teuer
            zuTeuer.enabled = true;
            Invoke("ZuTeuerdisable", 1.5f);
        }
    }
    public void StartLevel4()
    {
        if (PlayerPrefs.GetInt("Level4", 0) == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        }
        else if (geld >= 40)
        {
            Text4.SetActive(false);
            geld -= 40;
            PlayerPrefs.SetInt("Money", geld);
            PlayerPrefs.SetInt("Level4", 1);
           // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        }
        else
        {
            //zu teuer
            zuTeuer.enabled = true;
            Invoke("ZuTeuerdisable", 1.5f);
        }
    }
}
