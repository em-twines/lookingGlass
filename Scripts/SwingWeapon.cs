using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingWeapon : MonoBehaviour

{ 
private float swingDuration = 0.5f;
private float swingSpeed = 0.22f;

private float swingTimer = 0f;
private bool swinging = false;
private Vector3 startRot;

    void Start()
{
    startRot = transform.eulerAngles;


    }

// Update is called once per frame
void Update()
{
    if (Input.GetKeyDown(KeyCode.Space) && !swinging)
    {
        swinging = true;
    }

    if (swinging)
    {
        swingTimer += Time.deltaTime;

        if (swingTimer < (swingDuration / 2))
        {
            transform.eulerAngles = Vector3.Lerp(startRot, new Vector3(0, 0, 1), swingSpeed);
        }

        if (swingTimer > (swingDuration / 2))
        {
            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, startRot, swingSpeed);
        }

        if (swingTimer > swingDuration)
        {
            swingTimer = 0f;
            swinging = false;
        }
    }
}
}
    /*
    public Transform sunrise;
    public Transform sunset;

    // Time to move from sunrise to sunset position, in seconds.
    public float journeyTime = 1.0f;

    // The time at which the animation started.
    private float startTime;

    void Start()
    {
        // Note the time at the start of the animation.
        startTime = Time.time;
    }

    void Update()
    {
        // The center of the arc
        Vector3 center = (sunrise.position + sunset.position) * 0.5F;

        // move the center a bit downwards to make the arc vertical
        center -= new Vector3(0, 1, 0);

        // Interpolate over the arc relative to center
        Vector3 riseRelCenter = sunrise.position - center;
        Vector3 setRelCenter = sunset.position - center;

        // The fraction of the animation that has happened so far is
        // equal to the elapsed time divided by the desired time for
        // the total journey.
        float fracComplete = (Time.time - startTime) / journeyTime;

        transform.position = Vector3.Slerp(riseRelCenter, setRelCenter, fracComplete);
        transform.position += center;
    }
}


/*{
    //public float speed = 1.0f;

    // Transforms to act as start and end markers for the journey.
    public Transform startMarker;
    public Transform endMarker;

    // Movement speed in units per second.
    public float speed = 1.0F;

    // Time when the movement started.
    private float startTime;

    // Total distance between the markers.
    private float journeyLength;

    void Start()
    {

    }

    // Move to the target end position.
    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Return);

        if(down)
        {
            Swing();
        }

       
    }

    private void Swing()
    { 
        // Keep a note of the time the movement started.
        startTime = Time.time;

        // Calculate the journey length.
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    
        // Distance moved equals elapsed time times speed..
        float distCovered = (Time.time - startTime) * speed;

        // Fraction of journey completed equals current distance divided by total distance.
        float fractionOfJourney = distCovered / journeyLength;

        // Set our position as a fraction of the distance between the markers.
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fractionOfJourney);
    }



    /*
    void Start()
    {
        weaponTransform = transform.FindChild("sledgeHammer");

        void Update()
        {
            weaponTransform.transform.localPosition = Vector3.Slerp(weaponTransform.localPosition, new Vector3(1, 0, 1), 0.01f);
        }
    }
    
}
*/
