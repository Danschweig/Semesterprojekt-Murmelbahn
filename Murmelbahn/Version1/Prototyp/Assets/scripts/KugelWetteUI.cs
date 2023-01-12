using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KugelWetteUI : MonoBehaviour
{
    public string farbe = null; //1=rot,2=blau,3=grün
    private Text StartText;
    private void Start()
    {
        StartText = GameObject.FindGameObjectWithTag("starttext").GetComponent<Text>();
        StartText.enabled = false;
    }
    void Einblenden()
    {
        gameObject.SetActive(true);
    }
    void Ausblenden()
    {
        GameObject.FindGameObjectWithTag("murmeln").GetComponent<AudioSource>().Play();
        gameObject.SetActive(false);
        StartText.enabled = true;
    }
    void AusblendenInvoke()
    {
        Invoke("Ausblenden", 0.6f);
    }
    public void WetteAufRot()
    {
        farbe = " red";
        Ausblenden();
        GameObject.FindGameObjectWithTag("murmeln").GetComponent<Kugeln>().KinematicFalse();
    }
    public void WetteAufBlau()
    {
        farbe = "blue";
        Ausblenden();
        
        GameObject.FindGameObjectWithTag("murmeln").GetComponent<Kugeln>().KinematicFalse();
    }
    public void WetteAufGruen()
    {
        farbe = "green";
        Ausblenden();
        GameObject.FindGameObjectWithTag("murmeln").GetComponent<Kugeln>().KinematicFalse();
    }
    public string GewetteteFarbe()
    {
        return farbe;
    }
}
