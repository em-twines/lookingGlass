using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key5On : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Key5.Instance.gameObject.GetComponent<MeshRenderer>().enabled = true; 
        Key5.Instance.gameObject.GetComponent<BoxCollider>().enabled = true; 
    }

}
