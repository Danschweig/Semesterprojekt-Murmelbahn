using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class KugelWetteUI : MonoBehaviour
{
    public string farbe = null; //1=rot,2=blau,3=grün
    private Text StartText;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex != 2)
        {
            StartText = GameObject.FindGameObjectWithTag("starttext").GetComponent<Text>();
            StartText.enabled = false;
        }
    }
    void Einblenden()
    {
        gameObject.SetActive(true);
    }
    void Ausblenden()
    {
        GameObject.FindGameObjectWithTag("murmeln").GetComponent<AudioSource>().Play();
        gameObject.SetActive(false);
        if(SceneManager.GetActiveScene().buildIndex != 2)
            StartText.enabled = true;
        GameObject.FindGameObjectWithTag("murmeln").GetComponent<Kugeln>().KinematicFalse();
    }
    void AusblendenInvoke()
    {
        Invoke("Ausblenden", 0.6f);
    }
    public void WetteAufRot()
    {
        farbe = " red";
        AusblendenInvoke();
        //GameObject.FindGameObjectWithTag("murmeln").GetComponent<Kugeln>().KinematicFalse();
    }
    public void WetteAufBlau()
    {
        farbe = "blue";
        Ausblenden();
        
        //GameObject.FindGameObjectWithTag("murmeln").GetComponent<Kugeln>().KinematicFalse();
    }
    public void WetteAufGruen()
    {
        farbe = "green";
        Ausblenden();
        //GameObject.FindGameObjectWithTag("murmeln").GetComponent<Kugeln>().KinematicFalse();
    }
    public string GewetteteFarbe()
    {
        return farbe;
    }
}
