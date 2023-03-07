using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HammerText : MonoBehaviour
{

public GameObject hammerText;
public GameObject hammerText2; 

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Text", 115); 
        Destroy(hammerText, 120);
        Invoke("Text2", 121); 

    }

    void Text()
    {
        hammerText.GetComponent<Text>().text = "Click the Icon to Equip. \n Press 'Enter' to Attack. \r\n Try Hard";
    }
    // Update is called once per frame

    void Text2()
    {
    hammerText.GetComponent<Text>().text = "Try Hard";

    }
}
