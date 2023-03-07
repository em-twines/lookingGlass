using UnityEngine;
using UnityEngine.UI;

public class FinalDoorController2 : MonoBehaviour
{


    //public static bool gotKey2;                 //Has the player acquired key

    public GameObject mediaPlayerKey;
    public GameObject txtToDisplay;             //Display the information about how to close/open the door
    public int timeToStop = 10;



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

private void Awake()
{
    DontDestroyOnLoad(this);
     
}

    private void Start()
    {
        //gotKey2 = false;


        doorOpened = false;                     //Is the door currently opened
        playerInZone = false;                   //Player not in zone
        doorState = DoorState.Closed;           //Starting state is door closed

        mediaPlayerKey.SetActive(false);

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
                // Code for: standing in front of Opened door
                // txtToDisplay.GetComponent<Text>().text = "Press 'E' to Close";
                doorCollider.enabled = false;
            }
            else if (doorState == DoorState.Closed)
            {
                if (Inventory.gotKey2 == true)
                {
                    // Standing in front of Closed door, with key
                    txtToDisplay.GetComponent<Text>().text = "Press 'E' to Open";
                    doorCollider.enabled = true;
                } 
                else 
                {
                    // Standing in front of Closed door, without key
                    txtToDisplay.GetComponent<Text>().text = "Needs Key";
                    doorCollider.enabled = true;
                }   
            }
            else
            {
                // We know doorState == DoorState.Jammed
                if (Inventory.gotKey2 == true)
                {
                    // Standing in front of Jammed door, with key
                    txtToDisplay.GetComponent<Text>().text = "Press 'E' to Open";
                    doorCollider.enabled = true;
                } 
                else 
                {
                    // Standing in front of Jammed door, without key
                    txtToDisplay.GetComponent<Text>().text = "Needs Key";
                    doorCollider.enabled = true;
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.E) && playerInZone && !doorAnim.isPlaying)
        {
            //doorOpened = !doorOpened;           //The toggle function of door to open/close

            if (doorState == DoorState.Opened) 
            {
                // Pressed E on Opened door
                Debug.Log("Not closing door");
            } 
            else if (doorState == DoorState.Closed) 
            {
                if (Inventory.gotKey2 == true)
                {
                    // Code for: pressed E on closed door, with the key
                                       
                    mediaPlayerKey.SetActive(true);
                    GameObject.FindWithTag("videoCamera").GetComponent<Camera>().enabled = true;
                    CameraMain.Instance.gameObject.SetActive(false);
                    Destroy(mediaPlayerKey, timeToStop);
                    doorState = DoorState.Opened;
                    doorAnim.Play("Door_Open");


                    GameObject.Find("R1").GetComponent<MeshRenderer>().enabled = true;
                    GameObject.Find("R2").GetComponent<MeshRenderer>().enabled = true;
                    GameObject.Find("R3").GetComponent<MeshRenderer>().enabled = true;
                    GameObject.Find("R4").GetComponent<MeshRenderer>().enabled = true;
                    GameObject.Find("R5").GetComponent<MeshRenderer>().enabled = true;
                    GameObject.Find("R6").GetComponent<MeshRenderer>().enabled = true;
                    GameObject.Find("R7").GetComponent<MeshRenderer>().enabled = true;
                    GameObject.Find("ZoomTrigger").GetComponent<MeshRenderer>().enabled = true;

                    GameObject.Find("R1").GetComponent<BoxCollider>().enabled = true;
                    GameObject.Find("R2").GetComponent<BoxCollider>().enabled = true;
                    GameObject.Find("R3").GetComponent<BoxCollider>().enabled = true;
                    GameObject.Find("R4").GetComponent<BoxCollider>().enabled = true;
                    GameObject.Find("R5").GetComponent<BoxCollider>().enabled = true;
                    GameObject.Find("R6").GetComponent<BoxCollider>().enabled = true;
                    GameObject.Find("R7").GetComponent<BoxCollider>().enabled = true;
                    GameObject.Find("ZoomTrigger").GetComponent<BoxCollider>().enabled = true;
                    

                } 
                else 
                {
                    // Code for: pressed E on closed door, without the key
                    Debug.Log("Changing doorState to Jammed");
                    doorState = DoorState.Jammed;
                }
            } 
            else 
            {
                // We know doorState == DoorState.Jammed
                if (Inventory.gotKey2 == true) 
                {
                    // Pressed E on Jammed door, with the key
                    
                    mediaPlayerKey.SetActive(true);
                    GameObject.Find("AVcamera").GetComponent<Camera>().enabled = true;
                    CameraMain.Instance.gameObject.SetActive(false);
                    Destroy(mediaPlayerKey, timeToStop);
                    doorAnim.Play("Door_Open");
                    doorState = DoorState.Opened;

                    GameObject.Find("R1").GetComponent<MeshRenderer>().enabled = true;
                    GameObject.Find("R2").GetComponent<MeshRenderer>().enabled = true;
                    GameObject.Find("R3").GetComponent<MeshRenderer>().enabled = true;
                    GameObject.Find("R4").GetComponent<MeshRenderer>().enabled = true;
                    GameObject.Find("R5").GetComponent<MeshRenderer>().enabled = true;
                    GameObject.Find("R6").GetComponent<MeshRenderer>().enabled = true;
                    GameObject.Find("R7").GetComponent<MeshRenderer>().enabled = true;
                    GameObject.Find("ZoomTrigger").GetComponent<MeshRenderer>().enabled = true;

                    GameObject.Find("R1").GetComponent<BoxCollider>().enabled = true;
                    GameObject.Find("R2").GetComponent<BoxCollider>().enabled = true;
                    GameObject.Find("R3").GetComponent<BoxCollider>().enabled = true;
                    GameObject.Find("R4").GetComponent<BoxCollider>().enabled = true;
                    GameObject.Find("R5").GetComponent<BoxCollider>().enabled = true;
                    GameObject.Find("R6").GetComponent<BoxCollider>().enabled = true;
                    GameObject.Find("R7").GetComponent<BoxCollider>().enabled = true;
                    GameObject.Find("ZoomTrigger").GetComponent<BoxCollider>().enabled = true;
                    

                         
                } 
                else 
                {
                    // Pressed E on Jammed door, without the key

                }
            }
        }

         if (mediaPlayerKey == null)
        {
            CameraMain.Instance.gameObject.SetActive(true);
            GameObject.FindWithTag("videoCamera").GetComponent<Camera>().enabled = false;
            doorState = DoorState.Opened;


        }
    }

}


