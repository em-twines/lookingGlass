using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoToZoom2 : MonoBehaviour
{


    void Awake()
    {        

        GameObject.Find("R1").SetActive(false);
        GameObject.Find("R2").SetActive(false);
        GameObject.Find("R3").SetActive(false);
        GameObject.Find("R4").SetActive(false);
        GameObject.Find("R5").SetActive(false);
        GameObject.Find("R6").SetActive(false);
        GameObject.Find("R7").SetActive(false);
        GameObject.Find("ZoomTrigger").SetActive(false);

    }

    void Update()
    {
        if (GameObject.Find("mediaPlayerKey") == null)
            {
                GameObject.Find("R1").SetActive(true);
                GameObject.Find("R2").SetActive(true);
                GameObject.Find("R3").SetActive(true);
                GameObject.Find("R4").SetActive(true);
                GameObject.Find("R5").SetActive(true);
                GameObject.Find("R6").SetActive(true);
                GameObject.Find("R7").SetActive(true);
                GameObject.Find("ZoomTrigger").SetActive(true);


            }

    }
    

}
