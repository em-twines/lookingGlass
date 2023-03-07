
using UnityEngine;
using UnityEngine.UI;

public class Door1 : MonoBehaviour
{


public static Door1 Instance { get; private set; }
    void Awake()
    {
        if (Instance == null) { Instance = this; } else { Debug.Log("Warning: multiple " + this + " in scene!"); }
    }
    
}