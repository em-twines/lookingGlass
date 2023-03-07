using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideKeys : MonoBehaviour
{

    // Start is called before the first frame update
    void Awake()
    {
        Key1.Instance.gameObject.GetComponent<MeshRenderer>().enabled = false; 
        Key1.Instance.gameObject.GetComponent<BoxCollider>().enabled = false; 
        Key2.Instance.gameObject.GetComponent<MeshRenderer>().enabled = false; 
        Key2.Instance.gameObject.GetComponent<BoxCollider>().enabled = false; 
        Key3.Instance.gameObject.GetComponent<MeshRenderer>().enabled = false; 
        Key3.Instance.gameObject.GetComponent<BoxCollider>().enabled = false; 
        Key4.Instance.gameObject.GetComponent<MeshRenderer>().enabled = false; 
        Key4.Instance.gameObject.GetComponent<BoxCollider>().enabled = false; 
        Key5.Instance.gameObject.GetComponent<MeshRenderer>().enabled = false; 
        Key5.Instance.gameObject.GetComponent<BoxCollider>().enabled = false; 
        Key6.Instance.gameObject.GetComponent<MeshRenderer>().enabled = false; 
        Key6.Instance.gameObject.GetComponent<BoxCollider>().enabled = false; 
        Key7.Instance.gameObject.GetComponent<MeshRenderer>().enabled = false; 
        Key7.Instance.gameObject.GetComponent<BoxCollider>().enabled = false; 
        Key8.Instance.gameObject.GetComponent<MeshRenderer>().enabled = false; 
        Key8.Instance.gameObject.GetComponent<BoxCollider>().enabled = false; 
        
        //Key9.Instance.gameObject.GetComponent<MeshRenderer>().enabled = false; 
        //Key9.Instance.gameObject.GetComponent<BoxCollider>().enabled = false; 
    }

}
