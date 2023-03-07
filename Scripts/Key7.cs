using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key7 : InventoryItemBase
{


    public static Key7 Instance { get; private set; }
    void Awake()
    {
        if (Instance == null) { Instance = this; } else { Debug.Log("Warning: multiple " + this + " in scene!"); }

    }
public float scale = 1f; 
    public override string Name
    {
        get
        {
            return "key7";
        }
    }
    public override void OnUse()
    {
        base.OnUse();
    this.transform.localScale = new Vector3(scale, scale, scale);
    }
}