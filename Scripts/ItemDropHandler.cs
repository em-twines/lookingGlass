using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/*
public class ItemDropHandler : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        RectTransform invPanel = transform as RectTransform;
        if (!RectTransformUtility.RectangleContainsScreenPoint(invPanel, Input.mousePosition))
        {
            IInventoryItem item = eventData.pointerDrag.gameObject.GetComponent<NewItemDragHandler>().Item;
                 if (item != null)
                 {
                Inventory inventory = gameObject.GetComponent<Inventory>();
                inventory.RemoveItem(item);
                  item.OnDrop();
                  }
        }
        Debug.Log("Drop Item");
    }      
        
    
}
*/
