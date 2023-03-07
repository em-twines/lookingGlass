using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1Off : MonoBehaviour
{
    void Awake()
    {
    Door1.Instance.transform.GetChild(0).gameObject.GetComponent<MeshRenderer>().enabled = false;    
    Door1.Instance.transform.GetChild(1).gameObject.GetComponent<MeshRenderer>().enabled = false;    
    Door1.Instance.transform.GetChild(2).gameObject.GetComponent<MeshRenderer>().enabled = false;    
    Door1.Instance.transform.GetChild(3).gameObject.GetComponent<MeshRenderer>().enabled = false;    
    Door1.Instance.transform.GetChild(4).gameObject.GetComponent<MeshRenderer>().enabled = false;    
    Door1.Instance.transform.GetChild(5).GetChild(0).gameObject.GetComponent<MeshRenderer>().enabled = false;    
    Door1.Instance.transform.GetChild(5).GetChild(1).gameObject.GetComponent<MeshRenderer>().enabled = false;    
    Door1.Instance.transform.GetChild(5).gameObject.GetComponent<MeshRenderer>().enabled = false;    
   
    }

}
