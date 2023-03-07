using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RenderHeads.Media.AVProVideo;

public class PlayResponse5 : MonoBehaviour
{
    public float timeToStop = 3f;

    [SerializeField]
    private MediaPlayer mediaPlayer5;

    private void Awake()
    {
        HUDSingleton.Instance.gameObject.SetActive(false);


      //  Inventory.Instance.gameObject.SetActive(false);

        GameObject.Find("tempMainCamera5").SetActive(true);
        CameraMain.Instance.gameObject.SetActive(false);
    }





    private void Start()
    {
        Destroy(mediaPlayer5, timeToStop);

        Destroy(GameObject.Find("screen5"), timeToStop);
        Destroy(GameObject.Find("DL5"), timeToStop);

    }

    private void Update()
    {
        if (mediaPlayer5 == null)
        {
            HUDSingleton.Instance.gameObject.SetActive(true);

           // Inventory.Instance.gameObject.SetActive(true);


            CameraMain.Instance.gameObject.SetActive(true);
            GameObject.Find("tempMainCamera5").SetActive(false);
        }

    }

}
    
