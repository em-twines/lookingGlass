using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HangInThere : MonoBehaviour
{
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        text.GetComponent<Text>().text = "Survive your 9-5";
        Invoke("Stop", 3.8f) ;

    }

    private void Stop()
    {
        text.GetComponent<Text>().text = " "; 
    }

}
