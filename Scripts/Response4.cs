using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Response4 : MonoBehaviour
{

    public bool keyNeeded = false;              //Is key needed for the door
    public bool gotKey;                  //Has the player acquired key
    //public GameObject keyGameObject;            //If player has Key,  assign it here
   public GameObject txtToDisplay;             //Display the information about how to close/open the door

    private bool playerInZone;                  //Check if the player is in the zone
    public bool doorOpened;                    //Check if door is currently opened or not

    private Animation doorAnim;
    private BoxCollider doorCollider;           //To enable the player to go through the door if door is opened else block him
    public bool hasKey; 

    enum DoorState
    {
        Closed,
        Opened,
        Jammed
    }

    DoorState doorState = new DoorState();      //To check the current state of the door

    /// <summary>
    /// Initial State of every variables
    /// </summary>
  
  

  
    private void Start()
    {

        //txtToDisplay = GameObject.FindWithTag("text"); 
        gotKey = false;
        //doorOpened = false;                     //Is the door currently opened
        playerInZone = false;                   //Player not in zone
        doorState = DoorState.Closed;           //Starting state is door closed

        txtToDisplay.SetActive(false);

        doorAnim = transform.parent.gameObject.GetComponent<Animation>();
        doorCollider = transform.parent.gameObject.GetComponent<BoxCollider>();
        

        //hasKey is that there is no key gameObject
    }

        //If Key is needed and the KeyGameObject is not assigned, stop playing and throw error
        /* if (keyNeeded && keyGameObject == null)
         {
             UnityEditor.EditorApplication.isPlaying = false;
             Debug.LogError("Assign Key GameObject");
         }
         */
    
    private void OnTriggerEnter(Collider other)
    {
        txtToDisplay.SetActive(true);
        playerInZone = true;
    }

    private void OnTriggerExit(Collider other)
    {
        playerInZone = false;
        txtToDisplay.SetActive(false);
    }

    private void Update()
    {
       if (GameObject.Find("keypiece4") == null)
        {
            hasKey = true;
        }
        
        else
        {
            {
                hasKey = false; 
            }
        }

        //if you don't have the key
        if (hasKey == false)
        {



            //To Check if the player is in the zone and doesn't have key
            if (playerInZone)
            {
                if (doorState == DoorState.Opened)
                {
                // txtToDisplay.GetComponent<Text>().text = "Press 'E' to Close";
                    doorCollider.enabled = false;
                }
                
                else if (doorState == DoorState.Closed || gotKey)
                {
                    txtToDisplay.GetComponent<Text>().text = "Press 'E' to Open";
                    doorCollider.enabled = true;
                }
                
                else if (doorState == DoorState.Jammed)
                {
                    txtToDisplay.GetComponent<Text>().text = "Needs Key";
                    doorCollider.enabled = true;
                }
            }


        


            if (Input.GetKeyDown(KeyCode.E) && playerInZone)
            {
                doorOpened = !doorOpened;           //The toggle function of door to open/close

                 if (doorState == DoorState.Closed && !doorAnim.isPlaying)
                 {
                     if (!keyNeeded)
                     {
                        doorAnim.Play("Door_Open");
                        doorState = DoorState.Opened;
                        Destroy(txtToDisplay);
                        SceneManager.LoadScene("Response4");
                    }
                        
                }
                else if (keyNeeded && !gotKey)
                {
                        doorAnim.Play("Door_Jam");
                        doorState = DoorState.Jammed;
                }
            }


            

            if (doorState == DoorState.Closed && gotKey && !doorAnim.isPlaying)
            {
                    doorAnim.Play("Door_Open");
                    doorState = DoorState.Opened;
            }
    /*
                if (doorState == DoorState.Opened && !doorAnim.isPlaying)
                {
                    doorAnim.Play("Door_Close");
                    doorState = DoorState.Closed;
                }
    */
             if (doorState == DoorState.Jammed && !gotKey)
            {
                    doorAnim.Play("Door_Jam");
                    doorState = DoorState.Jammed;
            }
            else if (doorState == DoorState.Jammed && gotKey && !doorAnim.isPlaying)
            {
                    doorAnim.Play("Door_Open");
                    doorState = DoorState.Opened;
            }
            
         }
            
        else 
        {
          doorOpened = true;
          doorState = DoorState.Opened;
          doorCollider.enabled = false; 
          //doorAnim.Play("Door_Open"); 
        }

    }
}


