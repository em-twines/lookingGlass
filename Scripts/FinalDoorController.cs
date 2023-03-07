using UnityEngine;
using UnityEngine.UI;

public class FinalDoorController : MonoBehaviour
{

    public bool keyNeeded = true;             //Is key needed for the door


    //erase this for actual game
    public bool gotKey = false;                 //Has the player acquired key

    public GameObject videoPlayerKeyAnim;
    public int timeToStop;

    public GameObject keyGameObject1;
    public GameObject keyGameObject2;
    public GameObject keyGameObject3;
    public GameObject keyGameObject4;
    public GameObject keyGameObject5;
    public GameObject keyGameObject6;
    public GameObject keyGameObject7;
    public GameObject keyGameObject8;
    public GameObject keyGameObject9;           //If player has Key,  assign it here

    public GameObject txtToDisplay;             //Display the information about how to close/open the door

    private bool playerInZone;                  //Check if the player is in the zone
    private bool doorOpened;                    //Check if door is currently opened or not

    private Animation doorAnim;
    private BoxCollider doorCollider;           //To enable the player to go through the door if door is opened else block him

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

        //change  back
        gotKey = false;









        doorOpened = false;                     //Is the door currently opened
        playerInZone = false;                   //Player not in zone
        doorState = DoorState.Closed;           //Starting state is door closed

        videoPlayerKeyAnim.SetActive(false);

        txtToDisplay.SetActive(false);

        doorAnim = transform.parent.gameObject.GetComponent<Animation>();
        doorCollider = transform.parent.gameObject.GetComponent<BoxCollider>();

        //If Key is needed and the KeyGameObject is not assigned, stop playing and throw error
        /*
         *if (keyNeeded && !(keyGameObject1 && keyGameObject2 && keyGameObject3 && keyGameObject4 && keyGameObject5 && keyGameObject6 && keyGameObject7 && keyGameObject8 && keyGameObject9)) 
         {
             UnityEditor.EditorApplication.isPlaying = false;
             Debug.LogError("Not all collected");
         }
         */
    }

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
        //To Check if the player is in the zone
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

                videoPlayerKeyAnim.SetActive(true);

                Destroy(videoPlayerKeyAnim, timeToStop);
            }

            if (doorState == DoorState.Opened && !doorAnim.isPlaying)
            {
                doorAnim.Play("Door_Close");
                doorState = DoorState.Closed;
            }

            if (doorState == DoorState.Jammed && !gotKey)
            {
                doorAnim.Play("Door_Jam");
                doorState = DoorState.Jammed;
            }
            else if (doorState == DoorState.Jammed && gotKey && !doorAnim.isPlaying)
            {
                doorAnim.Play("Door_Open");
                doorState = DoorState.Opened;

                videoPlayerKeyAnim.SetActive(true);

                Destroy(videoPlayerKeyAnim, timeToStop);
            }
        }
    }

}


