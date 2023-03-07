using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RenderHeads.Media.AVProVideo;

public class PlayResponse1 : MonoBehaviour
{
    public float timeToStop = 75f;

    [SerializeField]
    private MediaPlayer mediaPlayer;

    private void Awake()
    {
        HUDSingleton.Instance.gameObject.SetActive(false);


      //  Inventory.Instance.gameObject.SetActive(false);



        GameObject.Find("tempMainCamera").SetActive(true);
        CameraMain.Instance.gameObject.SetActive(false);
    }





    private void Start()
    {
        Destroy(mediaPlayer, timeToStop);

        Destroy(GameObject.Find("screen"), timeToStop);
        Destroy(GameObject.Find("DL"), timeToStop);

    }

    private void Update()
    {
        if (mediaPlayer == null)
        {
            HUDSingleton.Instance.gameObject.SetActive(true);

           // Inventory.Instance.gameObject.SetActive(true);


            CameraMain.Instance.gameObject.SetActive(true);
            GameObject.Find("tempMainCamera").SetActive(false);
        }

    }

}
    
