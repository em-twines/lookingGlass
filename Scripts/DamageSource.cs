using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UnityStandardAssets.Characters.ThirdPerson
{

    public class DamageSource : MonoBehaviour
    {

        public bool _isCausingDamage = true;
        public static float DamageRepeatRate = 0.6f;
        //was .5


        public int DamageAmount = 1;
        public bool Repeating = true;



        private void Start()
        {
            Invoke("Damage", 1);
            
        }


        public void Damage()
        {
           ThirdPersonCharacter player = gameObject.GetComponent<ThirdPersonCharacter>();
           StartCoroutine(TakeDamage(player, DamageRepeatRate));
         
        }

        IEnumerator TakeDamage(ThirdPersonCharacter player, float DamageRepeatRate)
        {
            while (_isCausingDamage)
            {
                player.TakeDamage(DamageAmount);
                TakeDamage(player, DamageRepeatRate);
                yield return new WaitForSeconds(DamageRepeatRate);
            }
        }

    }
}




