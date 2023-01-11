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
        gewetteteKugelFarbe.text = "your bet: " + gewettetefarbe;//"auf " +gewettetefarbe+ " gewettet";
        
        if (gewettetefarbe == " red")
            background.GetComponent<FarbeErstKugHintergrund>().ChangeToRed();
        else if (gewettetefarbe == "blue")
            background.GetComponent<FarbeErstKugHintergrund>().ChangeToBlau();
        else if (gewettetefarbe == "green")
            background.GetComponent<FarbeErstKugHintergrund>().ChangeToGreen();
    
        }
}
