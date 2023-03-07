using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RenderHeads.Media.AVProVideo;

public class PlayResponse4 : MonoBehaviour
{
    public float timeToStop = 3f;

    [SerializeField]
    private MediaPlayer mediaPlayer4;

    private void Awake()
    {
        HUDSingleton.Instance.gameObject.SetActive(false);


      //  Inventory.Instance.gameObject.SetActive(false);

        GameObject.Find("tempMainCamera4").SetActive(true);
        CameraMain.Instance.gameObject.SetActive(false);
    }





    private void Start()
    {
        Destroy(mediaPlayer4, timeToStop);

        Destroy(GameObject.Find("screen4"), timeToStop);
        Destroy(GameObject.Find("DL4"), timeToStop);

    }

    private void Update()
    {
        if (mediaPlayer4 == null)
        {
            HUDSingleton.Instance.gameObject.SetActive(true);

           // Inventory.Instance.gameObject.SetActive(true);


            CameraMain.Instance.gameObject.SetActive(true);
            GameObject.Find("tempMainCamera4").SetActive(false);
        }

    }

}
    
