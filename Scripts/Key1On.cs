using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key1On : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Key1.Instance.gameObject.GetComponent<MeshRenderer>().enabled = true; 
        Key1.Instance.gameObject.GetComponent<BoxCollider>().enabled = true; 
    }

}
