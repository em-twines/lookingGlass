using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{

public void Awake()
{
   GameObject.Find("trash").transform.GetChild(0).GetChild(0).gameObject.SetActive(false);

}
    private void OnTriggerEnter(Collider other)
    {  

   GameObject.Find("trash").transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
    }
     

   private void OnTriggerExit()
   {
   GameObject.Find("trash").transform.GetChild(0).GetChild(0).gameObject.SetActive(false);

   }
}


