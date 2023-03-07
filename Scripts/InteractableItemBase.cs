using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItemBase : MonoBehaviour
{

    public string Name;
    public Sprite Image;
    public string InteractText = "Press Spacebar to pickup the item";
    public virtual void OnInteract()
    {

    }

    //public class InventoryItemBase: InteractableItemBase


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
