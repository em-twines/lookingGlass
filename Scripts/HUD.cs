
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{ 

    public Inventory Inventory;
    public GameObject MessagePanel;

    // Start is called before the first frame update
    void Start()
    {
        Inventory.ItemAdded += InventoryScript_ItemAdded;
        Inventory.ItemRemoved += Inventory_ItemRemoved;
    }

    private void InventoryScript_ItemAdded(object sender, InventoryEventArgs e)
    {
        Transform inventoryPanel = transform.Find("InventoryPanel");
        foreach (Transform slot in inventoryPanel)
        {
            if (transform.childCount > 0)
            {
                Transform imageTransform = slot.GetChild(0);
                Image image = imageTransform.GetComponent<Image>();
                NewItemDragHandler itemDragHandler = imageTransform.GetComponent<NewItemDragHandler>();
                

                if (!image.enabled)
                {
                    image.enabled = true;
                    image.sprite = e.Item.Image;
                    itemDragHandler.Item = e.Item;
                    

                    break;

                }
            }

        }
    }
   private void Inventory_ItemRemoved(object sender, InventoryEventArgs e)
            {
                Transform inventoryPanel = transform.Find("InventoryPanel");
                foreach (Transform slot in inventoryPanel)
                {
            if (transform.childCount > 0)
            {
                Transform imageTransform = slot.GetChild(0);
                Image image = imageTransform.GetComponent<Image>();
                NewItemDragHandler itemDragHandler = imageTransform.GetComponent<NewItemDragHandler>();


                if (itemDragHandler.Item.Equals(e.Item))
                {
                    image.enabled = false;
                    image.sprite = null;
                    itemDragHandler.Item = null;
                    break;
                }
            }
                
                }
            }
   /*
    
    public void OpenMessagePanel(string text)
    {
        MessagePanel.SetActive(true);
        //todo: set text
    }
    public void CloseMessagePanel()
    {
        MessagePanel.SetActive(false);
    }
    */
}
/*
internal class ItemDragHandler
{
    public IInventoryItem Item { get; internal set; }
}
*/