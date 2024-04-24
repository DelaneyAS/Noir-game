using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.XR;

public class ClickableDoors : MonoBehaviour
{
    public Transform spawnPoint;
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
}
