using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.XR;

public class ClickableDoors : MonoBehaviour
{
    public GameObject Door;
    public Transform spawnPoint;
    public static bool target1interact;
    public static bool target2interact;
    public static bool target3interact;
    private bool canInteractWithDoor;

    // Start is called before the first frame update
    private FirstPersonController controller;

 
    public void MovePlayer(FirstPersonController Player)
    {
        Player.transform.position = spawnPoint.position;
        controller = Player;
        Invoke("FadeOUT", 1f);
    }


    public void FadeOUT()
    {
        UIController.Instance.FadeOUT();
        controller.enabled = true;
    }
    void Update()
    {
        if (target1interact && target2interact && target3interact)
        {
            {
                canInteractWithDoor = true;
            }
            
        }
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("target1interact"))
        {
            target1interact = true;
            Debug.Log("clickableDoors target1interact: " + target1interact);
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
