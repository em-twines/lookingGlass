using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPick : MonoBehaviour
{
    private readonly Vector3 fwd;
    public GameObject playerHammer;
    public GameObject groundHammer;
    public GameObject UI;


    // Start is called before the first frame update
    void Start()
    {
        playerHammer.SetActive(false);
        UI.SetActive(false);
        playerHammer.SetActive(true);

        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 find = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        Ray ray;
        if (Physics.Raycast(transform.position, fwd, out hit))
        {
            if (hit.collider.tag == "sledgeHammer")
            {
            UI.SetActive(true);
            if(Input.GetKeyDown(KeyCode.Space))
            {
                groundHammer.SetActive(false);
                playerHammer.SetActive(true);
            }
        }
        else
        {
            UI.SetActive(false);
        }
    }
}
}
