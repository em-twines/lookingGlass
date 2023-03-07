using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDSingleton : MonoBehaviour
{

    public static HUDSingleton Instance { get; private set; }
    void Awake()
    {
        if (Instance == null) { Instance = this; } else { Debug.Log("Warning: multiple " + this + " in scene!"); }
    }


}
