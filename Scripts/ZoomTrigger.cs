using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//namespace UnityStandardAssets.Characters.ThirdPerson

public class ZoomTrigger : MonoBehaviour
{

        private void OnTriggerEnter(Collider other)
        {
           // if (keyPlayed == true)
                
                    SceneManager.LoadScene("FinalScene");
                
       
        }



    
}
