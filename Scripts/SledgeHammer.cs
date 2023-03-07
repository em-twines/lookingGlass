using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets.Characters.ThirdPerson
{


public class SledgeHammer : InventoryItemBase
{

   public static SledgeHammer Instance { get; private set; }
    void Awake()
    {
        if (Instance == null) { Instance = this; } else { Debug.Log("Warning: multiple " + this + " in scene!"); }

         GameObject.Find("CanvasA").gameObject.transform.GetChild(0).GetChild(10).gameObject.SetActive(false);


    }
    public GameObject txtToDisplaySH;
    //private bool playerInZoneSH = false; 
    //public static bool onUse = false;
    public GameObject player;

    public int delay = 214; 
    public override string Name
    {
        get
        {
            return "sledgeHammer";
        }
    }


    public override void OnUse()
    {
        base.OnUse();
        //onUse = true; 

    }


/*
    public virtual void OnUse()
    {
        transform.localPosition = PickPosition;
        transform.localEulerAngles = PickRotation;
        
    }

*/
    void Start()
    {
        SledgeHammer.Instance.gameObject.GetComponent<CapsuleCollider>().isTrigger = false;
        SledgeHammer.Instance.gameObject.GetComponent<CapsuleCollider>().enabled = false;

        Invoke("IsTrigger", delay);
        //214
    }

    void IsTrigger()
        {
          SledgeHammer.Instance.gameObject.GetComponent<CapsuleCollider>().enabled = true;

          SledgeHammer.Instance.gameObject.GetComponent<CapsuleCollider>().isTrigger = true;

        }



    private void OnTriggerEnter(Collider dataFromCollision)
  {
          if (dataFromCollision.gameObject.name == "ThirdPersonController")
        {       
            Debug.Log("hit the collider");
            GameObject.Find("CanvasA").gameObject.transform.GetChild(0).GetChild(10).gameObject.SetActive(true);
        
        }

  }
/*
    private void OnTriggerEnter(Collider other)
        {
            txtToDisplaySH.SetActive(true);
    
            txtToDisplaySH.GetComponent<Text>().text = "You picked up the SLEDGEHAMMER! \n Click the Icon. Press 'Enter' to Attack. \n Try Hard";

        }
        */
    }
}





