using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyMoveRooms : MonoBehaviour
{
private void  OnTriggerEnter()
    {
        SceneManager.LoadScene("doors_1");
    }

}
