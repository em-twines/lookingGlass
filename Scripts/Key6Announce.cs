using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key6Announce : MonoBehaviour
{

public GameObject Txt;


private void Start()
{
Invoke("Stop()", 3f);
}

private void Stop()
{
    this.enabled = false; 
}


private void OnTriggerEnter(Collider other)
    {
        if(GameObject.Find("keypiece6") == null)
     
     {
            Txt.SetActive(true);
            Txt.GetComponent<Text>().text = "You collected the \"Wills for 1\" Key Fragment!";
            Destroy(Txt, 3f);
     }
    }

}












