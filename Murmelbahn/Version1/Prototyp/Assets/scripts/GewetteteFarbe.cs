using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GewetteteFarbe : MonoBehaviour
{
    public Text gewetteteKugelFarbe;
    public GameObject background;
    private string gewettetefarbe;
    public GameObject GewetteteFarbeScript;

    // Start is called before the first frame update
    void Start()
    {
       // gewettetefarbe = GewetteteFarbeScript.GetComponent<KugelWetteUI>().GewetteteFarbe();
       
    }

    // Update is called once per frame
    void Update()
    {
        gewettetefarbe = GewetteteFarbeScript.GetComponent<KugelWetteUI>().GewetteteFarbe();
        gewetteteKugelFarbe.text = "auf " +gewettetefarbe+ " gewettet";
        
        if (gewettetefarbe == " rot")
            background.GetComponent<FarbeErstKugHintergrund>().ChangeToRed();
        else if (gewettetefarbe == "blau")
            background.GetComponent<FarbeErstKugHintergrund>().ChangeToBlau();
        else if (gewettetefarbe == "grün")
            background.GetComponent<FarbeErstKugHintergrund>().ChangeToGreen();
    
        }
}
