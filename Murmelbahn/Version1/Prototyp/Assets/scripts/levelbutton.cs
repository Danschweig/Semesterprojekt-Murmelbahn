using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelbutton : MonoBehaviour
{
    public void DisableButton()
    {
        
        gameObject.SetActive(false);
    }
    public void EnableButton()
    {
        gameObject.SetActive(true);
    }
    public void StartLevelScreen()
    {
        SceneManager.LoadScene(1);
    }
    public void StartStartScreen()
    {
        SceneManager.LoadScene(0);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
