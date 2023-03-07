using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class SetVariables : MonoBehaviour
{

    private void Awake()
    {

               GamePlayer.Instance.gameObject.transform.GetComponent<ThirdPersonCharacter>().GetComponent<DamageSource>().enabled = false;
       
              // HealthBar.health = 100;
   
  
    }
  

}