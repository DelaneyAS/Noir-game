using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingCutscene : MonoBehaviour
{
    public GameObject videoPlayer;

    void Start()
    {
        videoPlayer.SetActive(false);
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.CompareTag("Player")
)       {
            videoPlayer.SetActive(true);    
        }
        
        
    }
   
}
