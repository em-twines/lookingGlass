using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    public class GoToDoors : MonoBehaviour

    {


        private void OnTriggerEnter(Collider other)
        {
            //GameObject.Find("Main Camera").transform.GetComponent<FollowPlayer>().enabled = true;

           

           // GameObject.Find("HUD").transform.GetChild(1).gameObject.SetActive(true);

            SceneManager.LoadScene("FullScreen");
           // GameObject.Find("Camera").SetActive(true);
           // GameObject.Find("ThirdPersonController").transform.GetComponent<ThirdPersonCharacter>().GetComponent<DamageSource>().enabled = false;


        }



    }
}



