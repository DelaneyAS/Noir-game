using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    // Start is called before the first frame update
    public float _distance = 5f;
    public FirstPersonController player;
    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;

        Physics.Raycast(this.transform.position, transform.forward * _distance, out hit);
        {
            if (hit.collider.tag == "Door"  && Input.GetKeyDown(KeyCode.Mouse0))
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
