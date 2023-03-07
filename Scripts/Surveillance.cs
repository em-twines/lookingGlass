using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surveillance : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
     GameObject.Find("SurvCam").gameObject.GetComponent<Camera>().enabled = false;  
    GameObject.Find("SurvCam").gameObject.GetComponent<AudioListener>().enabled = false;    
  
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
     GameObject.Find("SurvCam").gameObject.GetComponent<Camera>().enabled = true;   
     GameObject.Find("SurvCam").gameObject.GetComponent<AudioListener>().enabled = true;    
 
    GameObject.Find("CameraOffice").gameObject.GetComponent<Camera>().enabled = false;  
    GameObject.Find("CameraOffice").gameObject.GetComponent<AudioListener>().enabled = false;     }

    void OnTriggerExit()
    {
    GameObject.Find("CameraOffice").gameObject.GetComponent<Camera>().enabled = true;  
    GameObject.Find("CameraOffice").gameObject.GetComponent<AudioListener>().enabled = true;  
     GameObject.Find("SurvCam").gameObject.GetComponent<Camera>().enabled = false;   
     GameObject.Find("SurvCam").gameObject.GetComponent<AudioListener>().enabled = false;    
 
    }
}
