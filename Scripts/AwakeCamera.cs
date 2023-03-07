using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeCamera : MonoBehaviour
{

    public void Awake()
    {
        transform.GetComponent<FollowPlayer>().enabled = true ;
        
        
    }


}
