/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSound : MonoBehaviour
{
    public GameObject AudioObject;

    void Start()
    {
        AudioObject = GameObject.Find("Audio Source");
    
   
    }

    void OnTriggerEnter(Collider other)
    {
        // If the entering collider is the player...
        if (other.tag == "Player")
        {
            // ... the player is in range.
            AudioObject.Stop();
        }
    }
}*/
