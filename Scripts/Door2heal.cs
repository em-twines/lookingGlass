
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets.Characters.ThirdPerson
{
public class Door2heal : MonoBehaviour
{

        private bool _isHealing = false;
        public float healRepeatRate = 0.5f;
        public int healAmount = 1;
        public bool Repeating = true;


public void Start()
{
    Invoke("StopHere", 3f);
}

public void StopHere()
{
    this.enabled = false; 
}
        
        


      private void OnTriggerEnter(Collider other)
        {
        if(GameObject.Find("keypiece2") == null)
           {
            _isHealing = true;

            ThirdPersonCharacter player = other.gameObject.GetComponent<ThirdPersonCharacter>();
                 if (player != null)
                 {
                     if (Repeating)
                        {
                            StartCoroutine(Heal(player, healRepeatRate));
                        }
                else
                    {
                    player.Heal(healAmount);
                    }
                }
           }
        }



        IEnumerator Heal(ThirdPersonCharacter player, float healRepeatRate)
        {
            while (_isHealing)
            {
                player.Heal(healAmount);
                Heal(player, healRepeatRate);
                yield return new WaitForSeconds(healRepeatRate);
            }
        }


        private void OnTriggerExit(Collider other)
        {
            ThirdPersonCharacter player = other.gameObject.GetComponent<ThirdPersonCharacter>();

            if (player != null)
            {
                _isHealing = false;
               

            }


        }


    }
}
