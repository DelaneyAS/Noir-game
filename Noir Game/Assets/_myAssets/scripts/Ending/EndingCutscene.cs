using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class EndingCutscene : MonoBehaviour
{
    public GameObject VideoPlayer;

    void Start()
    {
        GameObject camera = GameObject.Find("Main Camera");
        VideoPlayer.playOnAwake = false;
    }

    void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.CompareTag("Player"))
        {
            VideoPlayer.gameObject.SetActive(true); VideoPlayer.Play();
        }


    }
}
   

