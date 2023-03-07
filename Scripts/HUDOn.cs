using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDOn : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        HUDSingleton.Instance.gameObject.SetActive(true);
    }
}
