using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioClip SoundtoPlay;
    new AudioSource audio;
    public bool alreadyplayed = false;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {
        if(!alreadyplayed)
        {
            audio.PlayOneShot(SoundtoPlay);
            alreadyplayed = true;
        }
        if (other.tag == "Player")
        {
            audio.Stop();
        }
    }
   
}
