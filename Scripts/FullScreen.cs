using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FullScreen : MonoBehaviour
{


    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        text.GetComponent<Text>().text = "FullScreen Mode Advised";
        Invoke("Stop", 5f) ;

    }

    private void Stop()

    {
        SceneManager.LoadScene("doors_1");

    }

}
