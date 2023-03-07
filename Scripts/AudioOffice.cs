
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class AudioOffice : MonoBehaviour
{
    // two clips, perhaps songs for the game
    public AudioClip music;
    public AudioClip water;

    private AudioSource audioSource;
    private bool paused1;
    private bool paused2;

    float timer = 0.0f;
    public int seconds;


    public GameObject time; 



    // both songs are in paused state
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        paused1 = true;
        paused2 = true;
    }


     
     void Update()
     {
        timer += Time.deltaTime;
        int seconds = (int)timer; //% 60;
       // Debug.Log(seconds);


    
        if (seconds == 0) 
           {
             audioSource.clip = music;
             audioSource.Play(0);
             paused1= false;
             paused2= true;
        
            
           }
        if (seconds == 5) 
        {
            time.SetActive(true);
            time.GetComponent<Text>().text = "9am";
        }
                

        if (seconds == 14)
        {
            time.GetComponent<Text>().text = "10am";
        } 
           //water 1

        if (seconds == 24)
        {
            time.GetComponent<Text>().text = "11am";
        } 

            if (seconds == 27)
            {
                audioSource.clip = water;
                audioSource.Play(0);
                paused2 = false;
                paused1= true;
            }
             
        
             if (seconds == 34)
            {
                audioSource.clip = music;
                audioSource.Play(0);
                paused1 = false;
                paused2= true;
            }

        if (seconds == 36)
        {
            time.GetComponent<Text>().text = "12pm";
        } 

            //water 2

             if (seconds == 47)
            {
                audioSource.clip = water;
                audioSource.Play(0);
                paused2 = false;
                paused1= true;
            }
             

        if (seconds == 48)
        {
            time.GetComponent<Text>().text = "1pm";
        } 

             if (seconds == 56)
            {
                audioSource.clip = music;
                audioSource.Play(0);
                paused1 = false;
                paused2= true;
            }
        
        if (seconds == 60)
        {
            time.GetComponent<Text>().text = "2pm";
        } 


            //cwater 3

            if (seconds == 60)
            {
                audioSource.clip = water;
                audioSource.Play(0);
                paused2 = false;
                paused1= true;
            }
             
             if (seconds == 61)
            {
                audioSource.clip = music;
                audioSource.Play(0);
                paused1 = false;
                paused2= true;
            }

        if (seconds == 72)
        {
            time.GetComponent<Text>().text = "3pm";
        } 



            //long water 

            if (seconds == 76)
            {
                audioSource.clip = water;
                audioSource.Play(0);
                paused2 = false;
                paused1= true;
            }
             
        
        if (seconds == 84)
        {
            time.GetComponent<Text>().text = "4pm";
        } 

        if (seconds == 95)
        {
            time.GetComponent<Text>().text = "5pm";
        } 

             if (seconds == 98)
            {
                audioSource.clip = music;
                audioSource.Play(0);
                paused1 = false;
                paused2= true;
            }



        if (seconds == 108)
        {
            time.GetComponent<Text>().text = "6pm";
        } 

        if (seconds == 120)
        {
            time.GetComponent<Text>().text = "7pm";
        } 

        if (seconds == 132)
        {
            time.GetComponent<Text>().text = "8pm";
        } 

        if (seconds == 144)
        {
            time.GetComponent<Text>().text = "9pm";
        } 

        if (seconds == 156)
        {
            time.GetComponent<Text>().text = "10pm";
        } 

        if (seconds == 168)
        {
            time.GetComponent<Text>().text = "11pm";
        } 
        
        if (seconds == 180)
        {
            time.GetComponent<Text>().text = "12am";

        } 

        if (seconds == 192)
        {
            time.GetComponent<Text>().text = "1am";
        } 

        
        if (seconds == 204)
        {
            time.GetComponent<Text>().text = "2am";
        } 

        
        if (seconds == 216)
        {
            time.GetComponent<Text>().text = "3am";
        } 

        
        if (seconds == 228)
        {
            time.GetComponent<Text>().text = "4am";
        } 

        
        if (seconds == 240)
        {
            time.GetComponent<Text>().text = "5am";
        } 
    }
}


/*
    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 200, 100), "Play song1"))
        {
            if (paused1 && paused2)
            {
                audioSource.clip = song1;
                audioSource.Play(0);
                paused1 = false;
            }
        }

        if (GUI.Button(new Rect(250, 10, 200, 100), "Pause song1"))
        {
            if (paused1 == false)
            {
                audioSource.Pause();
                paused1 = true;
            }
        }

        if (GUI.Button(new Rect(10, 180, 200, 100), "Play song2"))
        {
            if (paused2 && paused1)
            {
                audioSource.clip = song2;
                audioSource.Play(0);
                paused2 = false;
            }
        }

        if (GUI.Button(new Rect(250, 180, 200, 100), "Pause song2"))
        {
            if (paused2 == false)
            {
                audioSource.Pause();
                paused2 = true;
            }
        }
    }
    */


