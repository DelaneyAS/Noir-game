using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject Door;
    private bool target1interact;
    private bool target2interact;
    private bool target3interact;

    void Update()
    {
        if (target1interact && target2interact && target3interact)
        {
            if (Door != null)
            {
                Door.SetActive(false);
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("target1interact"))
        {
            target1interact = true;
        }
        if (other.CompareTag("target2interact"))
        { 
            target2interact = true; 
        }
        if (other.CompareTag("target3interact"))
        {
            target3interact = true;
        }
        
    }

  
    
}
