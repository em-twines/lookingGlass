using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key1 : InventoryItemBase
{
    

    public static Key1 Instance { get; private set; }
    void Awake()
    {
        if (Instance == null) { Instance = this; } else { Debug.Log("Warning: multiple " + this + " in scene!"); }

    }
    
public float scale = 1f; 
    public override string Name
    {
        get
        {
            return "key1";
        }
    }

    
    public override void OnUse()
    {
        base.OnUse();
this.transform.localScale = new Vector3(scale, scale, scale);
    }
    
}

