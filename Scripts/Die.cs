using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets.Characters.ThirdPerson
{

public class Die : MonoBehaviour
{
    
    void Update()
    {
        if(ThirdPersonControllerSingleton.Instance.gameObject.GetComponent<ThirdPersonCharacter>().Health == 0)
        {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }    
    }
}
}


