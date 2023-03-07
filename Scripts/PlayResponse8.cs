using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RenderHeads.Media.AVProVideo;

public class PlayResponse8 : MonoBehaviour
{
    public float timeToStop = 3f;

    [SerializeField]
    private MediaPlayer mediaPlayer8;

    private void Awake()
    {
        HUDSingleton.Instance.gameObject.SetActive(false);


      //  Inventory.Instance.gameObject.SetActive(false);

        GameObject.Find("tempMainCamera8").SetActive(true);
        CameraMain.Instance.gameObject.SetActive(false);
    }





    private void Start()
    {
        Destroy(mediaPlayer8, timeToStop);

        Destroy(GameObject.Find("screen8"), timeToStop);
        Destroy(GameObject.Find("DL8"), timeToStop);

    }

    private void Update()
    {
        if (mediaPlayer8 == null)
        {
            HUDSingleton.Instance.gameObject.SetActive(true);

           // Inventory.Instance.gameObject.SetActive(true);


            CameraMain.Instance.gameObject.SetActive(true);
            GameObject.Find("tempMainCamera8").SetActive(false);
        }

    }

}
    
