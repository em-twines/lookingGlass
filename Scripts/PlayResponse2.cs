using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RenderHeads.Media.AVProVideo;

public class PlayResponse2 : MonoBehaviour
{
    public float timeToStop = 248f;

    [SerializeField]
    private MediaPlayer mediaPlayer2;

    private void Awake()
    {
        HUDSingleton.Instance.gameObject.SetActive(false);


      //  Inventory.Instance.gameObject.SetActive(false);

        GameObject.Find("tempMainCamera2").SetActive(true);
        CameraMain.Instance.gameObject.SetActive(false);
    }





    private void Start()
    {
        Destroy(mediaPlayer2, timeToStop);

        Destroy(GameObject.Find("screen2"), timeToStop);
        Destroy(GameObject.Find("DL2"), timeToStop);


    }

    private void Update()
    {
        if (mediaPlayer2 == null)
        {
            HUDSingleton.Instance.gameObject.SetActive(true);

           // Inventory.Instance.gameObject.SetActive(true);


            CameraMain.Instance.gameObject.SetActive(true);
            GameObject.Find("tempMainCamera2").SetActive(false);
        }

    }

}
    
