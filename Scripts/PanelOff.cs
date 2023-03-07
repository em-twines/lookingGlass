using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOff : MonoBehaviour
{
    void Awake()
    {
        PanelSingleton.Instance.gameObject.SetActive(false);
    }
}
