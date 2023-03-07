using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key2On : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Key2.Instance.gameObject.GetComponent<MeshRenderer>().enabled = true; 
        Key2.Instance.gameObject.GetComponent<BoxCollider>().enabled = true; 
    }

}


