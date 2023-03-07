using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key7On : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Key7.Instance.gameObject.GetComponent<MeshRenderer>().enabled = true; 
        Key7.Instance.gameObject.GetComponent<BoxCollider>().enabled = true; 
    }

}
