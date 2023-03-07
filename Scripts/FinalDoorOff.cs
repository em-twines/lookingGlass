using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDoorOff : MonoBehaviour
{

    void Awake()
    {
        FinalDoorSingleton.Instance.gameObject.SetActive(false);     
        
    }
}
