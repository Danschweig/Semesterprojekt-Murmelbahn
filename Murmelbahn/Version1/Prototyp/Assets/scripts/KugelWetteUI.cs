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
        gameObject.SetActive(false);
    }
    public void WetteAufRot()
    {
        farbe = "rot";
        Invoke("Ausblenden", 0.6f);
        GameObject.FindGameObjectWithTag("murmeln").GetComponent<Kugeln>().KinematicFalse();
    }
    public void WetteAufBlau()
    {
        farbe = "blau";
        Invoke("Ausblenden", 1);
        GameObject.FindGameObjectWithTag("murmeln").GetComponent<Kugeln>().KinematicFalse();
    }
    public void WetteAufGruen()
    {
        farbe = "grün"; 
        Invoke("Ausblenden", 1);
        GameObject.FindGameObjectWithTag("murmeln").GetComponent<Kugeln>().KinematicFalse();
    }
    public string GewetteteFarbe()
    {
        return farbe;
    }
}
