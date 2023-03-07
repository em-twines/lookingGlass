using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RenderHeads.Media.AVProVideo;

public class PlayCredits : MonoBehaviour
{
    public float timeToStop = 200.5f;

    [SerializeField]
    private MediaPlayer mediaPlayerFinal;

    private void Awake()
    {
        HUDSingleton.Instance.gameObject.SetActive(false);


      //  Inventory.Instance.gameObject.SetActive(false);

        GameObject.Find("tempMainCameraFinal").SetActive(true);
        CameraMain.Instance.gameObject.SetActive(false);
    }





    private void Start()
    {
        Destroy(mediaPlayerFinal, timeToStop);

        Destroy(GameObject.Find("screenFinal"), timeToStop);
       // Destroy(GameObject.Find("DLFinal"), timeToStop);


    }

    private void Update()
    {
        if (mediaPlayerFinal == null)
        {
            HUDSingleton.Instance.gameObject.SetActive(true);

           // Inventory.Instance.gameObject.SetActive(true);


            CameraMain.Instance.gameObject.SetActive(true);
            GameObject.Find("tempMainCameraFinal").SetActive(false);
        }

    }

}
    
