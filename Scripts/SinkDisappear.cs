using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkDisappear : MonoBehaviour
{
    private GameObject sink;

    /*
     if(curHealth <= 0)
 {
     GameObject.Destroy(gameObject);
 }


*/




















    /*
    void Start()
    {
        Collider sink = gameObject.GetComponent<Collider>();
        sink.isTrigger = false;

        Invoke("IsTrigger", 116.0f);


    }

    void IsTrigger()
    {
        Collider sink = gameObject.GetComponent<Collider>();
        sink.isTrigger = true;
        //Outputto console the GameObject’s trigger state
        Debug.Log("Trigger On : " + sink.isTrigger);

    

    private void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);


            // Set GameObject SetActive to false when
            // hit by a mouse click.

            if (hit)
            {
                hitInfo.transform.gameObject.SetActive(false);

            }


        }


    }*/
}
