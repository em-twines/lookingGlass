using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDoorOn : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        FinalDoorSingleton.Instance.gameObject.SetActive(true);

    }
}