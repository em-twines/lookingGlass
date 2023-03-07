using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOff : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        CameraMain.Instance.gameObject.SetActive(false);
       // AVCamera.Instance.gameObject.SetActive(false);
    }
}
