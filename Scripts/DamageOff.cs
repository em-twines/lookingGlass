using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    public class DamageOff : MonoBehaviour
    {
        private void Awake()
        {
            ThirdPersonControllerSingleton.Instance.transform.GetComponent<DamageSource>()._isCausingDamage = false;

        }
    }
}

