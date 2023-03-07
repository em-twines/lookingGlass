using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOn : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        CameraMain.Instance.gameObject.SetActive(true);
    }
}
