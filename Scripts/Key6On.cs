using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key6On : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Key6.Instance.gameObject.GetComponent<MeshRenderer>().enabled = true; 
        Key6.Instance.gameObject.GetComponent<BoxCollider>().enabled = true; 
    }

}
