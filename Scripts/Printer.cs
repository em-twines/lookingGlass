using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class Printer : MonoBehaviour

{
public void Awake()
{
   GameObject.Find("printer").transform.GetChild(0).GetChild(0).gameObject.SetActive(false);

}
    private void OnTriggerEnter(Collider other)
    {  

   GameObject.Find("printer").transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
    }
     

   private void OnTriggerExit()
   {
   GameObject.Find("printer").transform.GetChild(0).GetChild(0).gameObject.SetActive(false);

   }
}

