using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Characters.ThirdPerson
{ 

    public class SinkHealth : MonoBehaviour
    {
        private bool _isHealing = false;
        public float healRepeatRate = 0.05f;
        public int healAmount = 1;
        public bool Repeating = true;


        private void OnTriggerEnter(Collider other)
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