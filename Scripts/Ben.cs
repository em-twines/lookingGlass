
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ben : MonoBehaviour
{

public GameObject BenTxt;


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
        if(GameObject.Find("keypiece1") == null)
     {
            BenTxt.SetActive(true);
            BenTxt.GetComponent<Text>().text = "You collected the \"Heaven\" Key Fragment!";
            Destroy(BenTxt, 3f);
     }
    }

}









