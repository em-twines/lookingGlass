using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class Inventory : MonoBehaviour
{

public static bool gotKey2;

public GameObject sh2; 
public GameObject cup;

   public static Inventory Instance { get; private set; }



    void Awake()
    {
        if (Instance == null) { Instance = this; } else { Debug.Log("Warning: multiple " + this + " in scene!"); }
    
     //   SledgeHammer.Instance.gameObject.SetActive(false); 


    }




private const int SLOTS = 9;

    //was private
    public static List<IInventoryItem> mItems = new List<IInventoryItem>();
    public event EventHandler<InventoryEventArgs> ItemAdded;
    public event EventHandler<InventoryEventArgs> ItemRemoved;
    public event EventHandler<InventoryEventArgs> ItemUsed;

   



    void Start()
    {
        //RemoveItem(mItems.ElementAt(0));
      
     // Invoke("SetParent(cup)", 114);     
      // Debug.Log("setparent on");

     // Invoke("SledgeHammer.Instance.gameObject.GetComponent<CapsuleColilder>().enabled = true", 113);
     // Debug.Log("hammer SetAcive(true)");
     
      //  GameObject sh = (GameObject)Instantiate(Resources.Load("sledgeHammer"), new Vector3(3.915f, 0.604f, 2.1f), Quaternion.identity);
    }

    


    void Update()
    {

/*
        if(mItems.Count == 1)
            {
                if (GameObject.FindWithTag("sledgeHammer") == null)
                { 
                            sh2 = Instantiate (sh2, new Vector3(-0.1115f, 0.0517f, -0.0263f), Quaternion.identity) as GameObject;
                                        sh2.transform.SetParent(transform, false);

                }
            }
            */
        }

        public void SetParent(GameObject cup)
        {
        if (GameObject.FindWithTag("sledgeHammer") == null)
            {
                cup.transform.parent = cup.transform;
                if (cup.transform.parent != null )
                {
                    //Display the name of the grand parent of the player.
                    Debug.Log("Player's Grand parent: " + cup.transform.parent.parent.name);
                }
            }
        }






/* works
public void SetParent(GameObject cup)
{


        cup.transform.parent = cup.transform;
         if (cup.transform.parent != null )
        {
            //Display the name of the grand parent of the player.
            Debug.Log("Player's Grand parent: " + cup.transform.parent.parent.name);
        }
}
*/

/*

  if(mItems.Count == 1)
        {
            Debug.Log("count = 1");
            if (GameObject.FindGameObjectsWithTag("sledgeHammer") 
            {
            Debug.Log("sledgehammer = 2");
            Destroy(GameObject.Find("sledgeHammer"));
            Debug.Log("Destroy sledgehammer");
           }
        }



         if(GameObject.FindGameObjectsWithTag("sledgeHammer").Length > 1) 
        {
            Debug.Log(">1");

*/

    public void AddItem(IInventoryItem item)
    {
       
        if (mItems.Count < SLOTS)
        {
            Collider collider = (item as MonoBehaviour).GetComponent<Collider>();
            if (collider.enabled)
            {
                collider.enabled = false;

                mItems.Add(item);
                item.OnPickup();

                ItemAdded?.Invoke(this, new InventoryEventArgs(item));
             //   Debug.Log(mItems.ElementAt(0));

            }
        

            if (mItems.Count == SLOTS)
            {
                Debug.Log("slots full");
                //GameObject.Find("MainRoomManager").GetComponent<GoToZoom>().enabled = true; 

                gotKey2 = true;
                Debug.Log (gotKey2);

               
               // GameObject.Find("FinalDoor").transform.GetChild(6).GetComponent<FinalDoorController2>().gotKey2 = true;

                //GameObject finalDoor = GameObject.FindWithTag("finalDoor");
               // finalDoor.GetComponent<FinalDoorController2>().gotKey2 = true;
            }



        }



        
    }

    internal void UseItem(IInventoryItem item)
    {
        ItemUsed?.Invoke(this, new InventoryEventArgs(item));

    }



/*
    public void RemoveItem(IInventoryItem item)
    {
        if(mItems.Contains(item))
        {
            mItems.Remove(item);
            item.OnDrop();
            Collider collider = (item as MonoBehaviour).GetComponent<Collider>();
            if (collider != null)
            {
                collider.enabled = true;
            }
            ItemRemoved?.Invoke(this, new InventoryEventArgs(item));
        }
    }
    */

}

