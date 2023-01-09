using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KugelWetteUI : MonoBehaviour
{
    public string farbe = null; //1=rot,2=blau,3=grün
    void Einblenden()
    {
        gameObject.SetActive(true);
    }
    void Ausblenden()
    {
        GameObject.FindGameObjectWithTag("murmeln").GetComponent<AudioSource>().Play();
        gameObject.SetActive(false);
    }
    void AusblendenInvoke()
    {
        Invoke("Ausblenden", 0.6f);
    }
    public void WetteAufRot()
    {
        farbe = " rot";
        AusblendenInvoke();
        GameObject.FindGameObjectWithTag("murmeln").GetComponent<Kugeln>().KinematicFalse();
    }
    public void WetteAufBlau()
    {
        farbe = "blau";
        AusblendenInvoke();
        GameObject.FindGameObjectWithTag("murmeln").GetComponent<Kugeln>().KinematicFalse();
    }
    public void WetteAufGruen()
    {
        farbe = "grün";
        AusblendenInvoke();
        GameObject.FindGameObjectWithTag("murmeln").GetComponent<Kugeln>().KinematicFalse();
    }
    public string GewetteteFarbe()
    {
        return farbe;
    }
}
