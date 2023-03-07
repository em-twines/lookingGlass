using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key8On : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Key8.Instance.gameObject.GetComponent<MeshRenderer>().enabled = true; 
        Key8.Instance.gameObject.GetComponent<BoxCollider>().enabled = true; 
    }

}
