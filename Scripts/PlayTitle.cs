using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RenderHeads.Media.AVProVideo;
using UnityEngine.SceneManagement;

public class PlayTitle : MonoBehaviour
{
    public float timeToStop = 12f;

    [SerializeField]
    private MediaPlayer mediaPlayerTitle;

    private void Awake()
    {


    }

void Start()
{
        HUDSingleton.Instance.gameObject.SetActive(false);

        GameObject.Find("TitleCamera").SetActive(true);
        CameraMain.Instance.gameObject.SetActive(false);
    Destroy(GameObject.Find("Light"), timeToStop);
    Destroy(mediaPlayerTitle, timeToStop);

}
    void Update() 
    {
        if (mediaPlayerTitle == null)
        {
        SceneManager.LoadScene("office_v5_lights");

        }
    }
}
/*

    private void Start()
    {
    
        Invoke("Go()", timeToStop);


    }

void Go()
{
    SceneManager.LoadScene("office_v5_lights");

    private void Update()
    {
        if (mediaPlayerTitle == null)
        {
            HUDSingleton.Instance.gameObject.SetActive(true);

           // Inventory.Instance.gameObject.SetActive(true);


            CameraMain.Instance.gameObject.SetActive(true);
            GameObject.Find("TitleCamera").SetActive(false);
        }

    }
    */


    
