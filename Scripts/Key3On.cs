using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key3On : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Key3.Instance.gameObject.GetComponent<MeshRenderer>().enabled = true; 
        Key3.Instance.gameObject.GetComponent<BoxCollider>().enabled = true; 
    }

}
