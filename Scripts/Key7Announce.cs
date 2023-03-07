using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key7Announce : MonoBehaviour
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
        if(GameObject.Find("keypiece7") == null)
     
     {
            Txt.SetActive(true);
            Txt.GetComponent<Text>().text = "You collected the \"March 2020 - ?\" Key Fragment!";
            Destroy(Txt, 3f);
     }
    }

}












