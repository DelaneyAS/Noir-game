using System;
using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    // Start is called before the first frame update
    //readonly bool Test1 = ClickableDoors.target1interact;
    //readonly bool Test2 = ClickableDoors.target2interact;
    //readonly bool Test3 = ClickableDoors.target3interact;
    
    public float _distance = 5f;
    public FirstPersonController player;
    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;

        Physics.Raycast(this.transform.position, transform.forward * _distance, out hit);
        {
            if (hit.collider.CompareTag("Door") && Input.GetKeyDown(KeyCode.Mouse0)) //&& Test1 == true && Test2 == true && Test3 == true)
            {
                UIController.Instance.FadeIN();
                ClickableDoors door = hit.collider.GetComponent<ClickableDoors>();
                player.enabled = false;
                door.MovePlayer(player);
            }
        }
        Debug.DrawRay(this.transform.position, transform.forward * _distance, Color.red);
    }

}
