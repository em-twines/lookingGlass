using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemClickHandler : MonoBehaviour
{
    public Inventory _Inventory;

    public void OnItemClicked()
    {
        NewItemDragHandler dragHandler = 
        gameObject.transform.Find("ItemImage").GetComponent<NewItemDragHandler>();

        IInventoryItem item = dragHandler.Item;

        Debug.Log(item.Name);

        _Inventory.UseItem(item);


        item.OnUse();
    }





}
