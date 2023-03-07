using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RenderHeads.Media.AVProVideo;

public class PlayResponse6 : MonoBehaviour
{
    public float timeToStop = 3f;

    [SerializeField]
    private MediaPlayer mediaPlayer6;

    private void Awake()
    {
        HUDSingleton.Instance.gameObject.SetActive(false);


      //  Inventory.Instance.gameObject.SetActive(false);

        GameObject.Find("tempMainCamera6").SetActive(true);
        CameraMain.Instance.gameObject.SetActive(false);
    }





    private void Start()
    {
        Destroy(mediaPlayer6, timeToStop);

        Destroy(GameObject.Find("screen6"), timeToStop);
        Destroy(GameObject.Find("DL6"), timeToStop);

    }

    private void Update()
    {
        if (mediaPlayer6 == null)
        {
            HUDSingleton.Instance.gameObject.SetActive(true);

           // Inventory.Instance.gameObject.SetActive(true);


            CameraMain.Instance.gameObject.SetActive(true);
            GameObject.Find("tempMainCamera6").SetActive(false);
        }

    }

}
    
