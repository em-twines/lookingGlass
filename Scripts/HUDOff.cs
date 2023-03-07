using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDOff : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        HUDSingleton.Instance.gameObject.SetActive(false);
    }
}