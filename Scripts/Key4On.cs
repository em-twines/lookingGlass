using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key4On : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Key4.Instance.gameObject.GetComponent<MeshRenderer>().enabled = true; 
        Key4.Instance.gameObject.GetComponent<BoxCollider>().enabled = true; 
    }

}
