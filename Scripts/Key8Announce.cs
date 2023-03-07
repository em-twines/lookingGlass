using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key8Announce : MonoBehaviour
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
        if(GameObject.Find("keypiece8") == null)
     
     {
            Txt.SetActive(true);
            Txt.GetComponent<Text>().text = "You collected the \"Maryam Told Me We Will Always Have Nowruz\" Key Fragment!";
            Destroy(Txt, 5f);
     }
    }

}












