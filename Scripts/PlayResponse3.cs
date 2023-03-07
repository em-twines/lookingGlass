using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RenderHeads.Media.AVProVideo;

public class PlayResponse3 : MonoBehaviour
{
    public float timeToStop = 3f;

    [SerializeField]
    private MediaPlayer mediaPlayer3;

    private void Awake()
    {
        HUDSingleton.Instance.gameObject.SetActive(false);


      //  Inventory.Instance.gameObject.SetActive(false);

        GameObject.Find("tempMainCamera3").SetActive(true);
        CameraMain.Instance.gameObject.SetActive(false);
    }





    private void Start()
    {
        Destroy(mediaPlayer3, timeToStop);

        Destroy(GameObject.Find("screen3"), timeToStop);
        Destroy(GameObject.Find("DL3"), timeToStop);

    }

    private void Update()
    {
        if (mediaPlayer3 == null)
        {
            HUDSingleton.Instance.gameObject.SetActive(true);

           // Inventory.Instance.gameObject.SetActive(true);


            CameraMain.Instance.gameObject.SetActive(true);
            GameObject.Find("tempMainCamera3").SetActive(false);
        }

    }

}
    
