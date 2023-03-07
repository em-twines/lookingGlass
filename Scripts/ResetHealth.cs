using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityStandardAssets.Characters.ThirdPerson
{
public class ResetHealth : MonoBehaviour
{    

    void Awake()
    {


    

        ThirdPersonControllerSingleton.Instance.gameObject.GetComponent<ThirdPersonCharacter>().Health = 100;
        ThirdPersonControllerSingleton.Instance.gameObject.transform.position = new Vector3(0,0,0);

        ThirdPersonControllerSingleton.Instance.gameObject.transform.localRotation = Quaternion.Euler(0,270,0);
        // new Vector3(
               // ThirdPersonUserControl.Instance.gameObject.transform.eulerAngles.x,
               // ThirdPersonUserControl.Instance.gameObject.transform.eulerAngles.y,
               // ThirdPersonUserControl.Instance.gameObject.transform.eulerAngles.z);

    
    }
    
}

}

